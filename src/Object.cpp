/*
 * Object.cpp
 *
 *  Created on: Jan 31, 2016
 *      Author: exelim
 */

#include "Object.h"
#include <stdio.h>
#include <Elementary_GL_Helpers.h>

extern Evas_GL_API * __evas_gl_glapi;

////////////////////////////////////////////////TGA///////////////////////////////////////////////
#pragma pack(push,x1)					// Byte alignment (8-bit)
#pragma pack(1)

typedef struct
{
	unsigned char  identsize;			// size of ID field that follows 18 byte header (0 usually)
	unsigned char  colourmaptype;		// type of colour map 0=none, 1=has palette
	unsigned char  imagetype;			// type of image 2=rgb uncompressed, 10 - rgb rle compressed

	short colourmapstart;				// first colour map entry in palette
	short colourmaplength;				// number of colours in palette
	unsigned char  colourmapbits;		// number of bits per palette entry 15,16,24,32

	short xstart;						// image x origin
	short ystart;						// image y origin
	short width;						// image width in pixels
	short height;						// image height in pixels
	unsigned char  bits;				// image bits per pixel 24,32
	unsigned char  descriptor;			// image descriptor bits (vh flip bits)

										// pixel data follows header

} TGA_HEADER;

#pragma pack(pop,x1)

const int IT_COMPRESSED = 10;
const int IT_UNCOMPRESSED = 2;

void LoadCompressedImage(char* pDest, char * pSrc, TGA_HEADER * pHeader)
{
	int w = pHeader->width;
	int h = pHeader->height;
	int rowSize = w * pHeader->bits / 8;
	bool bInverted = ((pHeader->descriptor & (1 << 5)) != 0);
	char * pDestPtr = bInverted ? pDest + (h + 1) * rowSize : pDest;
	int countPixels = 0;
	int nPixels = w * h;

	while (nPixels > countPixels)
	{
		unsigned char chunk = *pSrc++;
		if (chunk < 128)
		{
			int chunkSize = chunk + 1;
			for (int i = 0; i < chunkSize; i++)
			{
				if (bInverted && (countPixels % w) == 0)
					pDestPtr -= 2 * rowSize;
				*pDestPtr++ = pSrc[2];
				*pDestPtr++ = pSrc[1];
				*pDestPtr++ = pSrc[0];
				pSrc += 3;
				if (pHeader->bits != 24)
					*pDestPtr++ = *pSrc++;
				countPixels++;
			}
		}
		else
		{
			int chunkSize = chunk - 127;
			for (int i = 0; i < chunkSize; i++)
			{
				if (bInverted && (countPixels % w) == 0)
					pDestPtr -= 2 * rowSize;
				*pDestPtr++ = pSrc[2];
				*pDestPtr++ = pSrc[1];
				*pDestPtr++ = pSrc[0];
				if (pHeader->bits != 24)
					*pDestPtr++ = pSrc[3];
				countPixels++;
			}
			pSrc += (pHeader->bits >> 3);
		}
	}
}

void LoadUncompressedImage(char* pDest, char * pSrc, TGA_HEADER * pHeader)
{
	int w = pHeader->width;
	int h = pHeader->height;
	int rowSize = w * pHeader->bits / 8;
	bool bInverted = ((pHeader->descriptor & (1 << 5)) != 0);
	for (int i = 0; i < h; i++)
	{
		char * pSrcRow = pSrc +
			(bInverted ? (h - i - 1) * rowSize : i * rowSize);
		if (pHeader->bits == 24)
		{
			for (int j = 0; j < w; j++)
			{
				*pDest++ = pSrcRow[2];
				*pDest++ = pSrcRow[1];
				*pDest++ = pSrcRow[0];
				pSrcRow += 3;
			}
		}
		else
		{
			for (int j = 0; j < w; j++)
			{
				*pDest++ = pSrcRow[2];
				*pDest++ = pSrcRow[1];
				*pDest++ = pSrcRow[0];
				*pDest++ = pSrcRow[3];
				pSrcRow += 4;
			}
		}
	}
}


char * LoadTGA(const char * szFileName, int * width, int * height, int * bpp)
{

	FILE * f = fopen(szFileName, "rb");

	if (f == 0)
		return NULL;

	TGA_HEADER header;
	fread(&header, sizeof(header), 1, f);

	fseek(f, 0, SEEK_END);
	int fileLen = ftell(f);
	fseek(f, sizeof(header) + header.identsize, SEEK_SET);

	if (header.imagetype != IT_COMPRESSED && header.imagetype != IT_UNCOMPRESSED)
	{
		fclose(f);
		return NULL;
	}

	if (header.bits != 24 && header.bits != 32)
	{
		fclose(f);
		return NULL;
	}

	int bufferSize = fileLen - sizeof(header) - header.identsize;
	char * pBuffer = new char[bufferSize];; //malloc( sizeof(char) * ( bufferSize + 1 ) ); //new char[bufferSize];
	fread(pBuffer, 1, bufferSize, f);
	fclose(f);

	*width = header.width;
	*height = header.height;
	*bpp = header.bits;
	char * pOutBuffer = new char[header.width * header.height * header.bits / 8]; //malloc( sizeof(char) * ( (header.width * header.height * header.bits / 8) + 1 ) ); //new char[header.width * header.height * header.bits / 8];

	switch (header.imagetype)
	{
	case IT_UNCOMPRESSED:
		LoadUncompressedImage(pOutBuffer, pBuffer, &header);
		break;
	case IT_COMPRESSED:
		LoadCompressedImage(pOutBuffer, pBuffer, &header);
		break;
	}

	free (pBuffer);

	return pOutBuffer;
}


/////////////////////////////////////////////////////////////////////////////////////////////////////

const float Vertices[] = {
		-1.0f, -1.0f, 0.f, 0.0f, 0.0f,
		-1.0f, 1.0f, 0.f, 0.f, 1.0f,
		1.0f, 1.0f, 0.f, 1.f, 1.0f,
		1.0f, -1.0f, 0.f, 1.f, 0.0f
	};

const unsigned short Indices[] = { 0, 1, 2,
							   0, 2, 3
	};

/* Vertext Shader Source */
static const char vertex_shader[] =
		"attribute vec3 a_position;  \n"
		"attribute vec2 TexCoord;    \n"
		"varying vec2 TexCoord0;     \n"
		"void main()\n"
		"{\n"
		"   gl_Position = vec4(a_position.x,a_position.y,a_position.z,1.0);\n"
		"	TexCoord0 = TexCoord; 			\n"
		"}";


/* Fragment Shader Source */
static const char fragment_shader[] =
		"precision mediump float;\n"
		"varying vec2 TexCoord0;       \n"
		"uniform sampler2D gSampler;   \n"
		"\n"
		"void main (void)\n"
		"{\n"
		"    gl_FragColor = texture2D(gSampler, TexCoord0); \n"
		"}";

GLuint gSampler;

Object::Object()
:program(0),
vtx_shader(0),
fgmt_shader(0),
texture(0),
idx_vbo(0),
idx_ibo(0),
idx_vposition(0),
type(OBJECT)
{}

void Object::Init(char* path, float vert[])
{
	for(int i = 0; i < 20; i++)
	{
		verticies[i] = vert[i];
	}
	glGenBuffers(1, &idx_vbo);
			glBindBuffer(GL_ARRAY_BUFFER, idx_vbo);
			glBufferData(GL_ARRAY_BUFFER, sizeof(verticies),
					verticies, GL_STATIC_DRAW);

			glGenBuffers(1, &idx_ibo);
			glBindBuffer(GL_ELEMENT_ARRAY_BUFFER, idx_ibo);
			glBufferData(GL_ELEMENT_ARRAY_BUFFER,
					sizeof(Indices), Indices,
					GL_STATIC_DRAW);

	InitShader();
	InitTexture(path);
}

void Object::InitShader()
{
	const char *p;

	p = vertex_shader;
	vtx_shader = glCreateShader(GL_VERTEX_SHADER);
	glShaderSource(vtx_shader, 1, &p, NULL);
	glCompileShader(vtx_shader);

	p = fragment_shader;
	fgmt_shader = glCreateShader(GL_FRAGMENT_SHADER);
	glShaderSource(fgmt_shader, 1, &p, NULL);
	glCompileShader(fgmt_shader);

	program = glCreateProgram();
	glAttachShader(program, vtx_shader);
	glAttachShader(program, fgmt_shader);

	glLinkProgram(program);
}

void Object::InitTexture(char* path)
{
	int width, height, bpp;

	char * bufferTGA = LoadTGA(path, &width, &height, &bpp);

	glUniform1i(gSampler, 0);

	glGenTextures(1, &texture);
	glBindTexture(GL_TEXTURE_2D, texture); // unsigned int texture_id;
	glTexImage2D(GL_TEXTURE_2D, 0, GL_RGBA, width, height, // int texture_width, texture_height;
			0, GL_RGBA, GL_UNSIGNED_BYTE, bufferTGA); // void *texture_data;

	glTexParameteri(GL_TEXTURE_2D, GL_TEXTURE_MIN_FILTER, GL_NEAREST);
	glTexParameteri(GL_TEXTURE_2D, GL_TEXTURE_MAG_FILTER, GL_NEAREST);
}

void Object::Draw()
{
	glUseProgram(program);
	glEnableVertexAttribArray(0);
	glEnableVertexAttribArray(1);

	glBindBuffer(GL_ARRAY_BUFFER, idx_vbo);
	glVertexAttribPointer(0, 3, GL_FLOAT, GL_FALSE, sizeof(float) * 5, 0);
	glVertexAttribPointer(1, 2, GL_FLOAT, GL_FALSE, sizeof(float) * 5, (void*)(3*sizeof(float)));


	glActiveTexture(GL_TEXTURE0);
	glBindTexture(GL_TEXTURE_2D, texture); // unsigned int texture_id;

	glBindBuffer(GL_ELEMENT_ARRAY_BUFFER, idx_ibo);
	glDrawElements(GL_TRIANGLES, 6, GL_UNSIGNED_SHORT, 0);

	glDisableVertexAttribArray(0);
	glDisableVertexAttribArray(1);
	glUseProgram(0);
}
