/*
 * Object.h
 *
 *  Created on: Jan 31, 2016
 *      Author: exelim
 */

#ifndef OBJECT_H_
#define OBJECT_H_


class Object
{
public:
	Object();

	void Init(char* path, float vert[]);

	void InitShader();
	void InitTexture(char* path);

	void Draw();

	enum TYPE {OBJECT, BIRD, PIPE};

private:
	unsigned int program;
	unsigned int vtx_shader;
	unsigned int fgmt_shader;

	unsigned int texture;

	unsigned int idx_vbo;
	unsigned int idx_ibo;
	unsigned int idx_vposition;

	float  verticies[20];

	TYPE type;

};


#endif /* OBJECT_H_ */
