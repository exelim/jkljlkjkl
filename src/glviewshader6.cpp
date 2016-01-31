/*
 * Copyright (c) 2014 Samsung Electronics Co., Ltd All Rights Reserved
 *
 * Licensed under the Apache License, Version 2.0 (the License);
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an AS IS BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

#include <app.h>
#include <Elementary_GL_Helpers.h>
#include <efl_extension.h>
#include "glviewshader6_utils.h"
#include "glviewshader6.h"
#include <stdio.h>
#include <string>

#include "Object.h"

ELEMENTARY_GLVIEW_GLOBAL_DEFINE();

enum  GS {CHOOSE_LANGUAGE, TRAINING, MAIN_MENU, IN_GAME, SCORE};

GS current_state;

char * language = "";

Object bg, bird, options_btn, start_btn;
Object fb_title, UA, US;
Object score_board, game_over;

static void win_back_cb(void *data, Evas_Object *obj, void *event_info) {
	appdata_s *ad = (appdata_s *)data;
	/* Let window go to hidden state. */
	elm_win_lower(ad->win);
}

static void init_shaders(Evas_Object *obj) {
	/*appdata_s *ad = (appdata_s *)evas_object_data_get(obj, "ad");
	const char *p;

	p = vertex_shader;
	ad->vtx_shader = glCreateShader(GL_VERTEX_SHADER);
	glShaderSource(ad->vtx_shader, 1, &p, NULL);
	glCompileShader(ad->vtx_shader);

	p = fragment_shader;
	ad->fgmt_shader = glCreateShader(GL_FRAGMENT_SHADER);
	glShaderSource(ad->fgmt_shader, 1, &p, NULL);
	glCompileShader(ad->fgmt_shader);

	ad->program = glCreateProgram();
	glAttachShader(ad->program, ad->vtx_shader);
	glAttachShader(ad->program, ad->fgmt_shader);

	glLinkProgram(ad->program);

	//ad->idx_vposition = glGetAttribLocation(ad->program, "a_position");


	int width, height, bpp;

	char * bufferTGA = LoadTGA("/opt/usr/apps/org.example.glviewshader6/shared/res/bird.tga", &width, &height, &bpp);

	glGenTextures(1, &ad->texture);
	glBindTexture(GL_TEXTURE_2D, ad->texture); // unsigned int texture_id;
	glActiveTexture(GL_TEXTURE0);
	glUniform1i(gSampler, 0);


	glTexImage2D(GL_TEXTURE_2D, 0, GL_RGBA, width, height, // int texture_width, texture_height;
			0, GL_RGBA, GL_UNSIGNED_BYTE, bufferTGA); // void *texture_data;

	glTexParameteri(GL_TEXTURE_2D, GL_TEXTURE_MIN_FILTER, GL_NEAREST);
	glTexParameteri(GL_TEXTURE_2D, GL_TEXTURE_MAG_FILTER, GL_NEAREST);

	glUseProgram(ad->program);*/
}

static void resize_gl(Evas_Object *obj)
{
	appdata_s *ad = (appdata_s *)evas_object_data_get(obj, "ad");

	elm_glview_size_get(obj, &ad->glview_w, &ad->glview_h);
}

void InitLanguageButtons()
{
	float btn_start_verticies[] = {
		-0.5f, -0.2f, 0.f, 0.0f, 0.0f,
		-0.5f, 0.2f, 0.f,  0.f, 1.0f,
		0.5f, 0.2f, 0.f, 1.f, 1.0f,
		0.5f, -0.2f, 0.f, 1.f, 0.0f
	};

	float btn_language_verticies[] = {
		-0.5f, -0.8f, 0.f, 0.0f, 0.0f,
		-0.5f, -0.4f, 0.f, 0.f, 1.0f,
		0.5f, -0.4f, 0.f, 1.f, 1.0f,
		0.5f, -0.8f, 0.f, 1.f, 0.0f
	};

	float fb_title_verticies[] = {
		-0.8f, 0.4f, 0.f, 0.0f, 0.0f,
		-0.8f, 0.8f, 0.f, 0.f, 1.0f,
		0.8f, 0.8f, 0.f, 1.f, 1.0f,
		0.8f, 0.4f, 0.f, 1.f, 0.0f
	};



	/*Vertex score_board_verticies[4] = {
		Vertex(Vector3f(-0.7f, -0.5f, 0.f), Vector2f(0.0f, 0.0f)),
		Vertex(Vector3f(-0.7f, 0.3f, 0.f),      Vector2f(0.f, 1.0f)),
		Vertex(Vector3f(0.7f, 0.3f, 0.f), Vector2f(1.f, 1.0f)),
		Vertex(Vector3f(0.7f, -0.5f, 0.f), Vector2f(1.f, 0.0f))
	};

	score_board

	Vertex game_over_verticies[4] = {
		Vertex(Vector3f(-0.8f, 0.4f, 0.f), Vector2f(0.0f, 0.0f)),
		Vertex(Vector3f(-0.8f, 0.8f, 0.f),      Vector2f(0.f, 1.0f)),
		Vertex(Vector3f(0.8f, 0.8f, 0.f), Vector2f(1.f, 1.0f)),
		Vertex(Vector3f(0.8f, 0.4f, 0.f), Vector2f(1.f, 0.0f))
	};*/
	char tmp[150];

	snprintf (tmp, 150, "%s%s%s","/opt/usr/apps/org.example.glviewshader6/shared/res/language_",language,".tga");
	options_btn.Init(tmp, btn_language_verticies);

	snprintf(tmp, 150, "%s%s%s","/opt/usr/apps/org.example.glviewshader6/shared/res/start_btn_",language,".tga");
	start_btn.Init(tmp, btn_start_verticies);

	fb_title.Init("/opt/usr/apps/org.example.glviewshader6/shared/res/fb_title.tga", fb_title_verticies);

}

static void draw_gl(Evas_Object *obj)
{
	appdata_s *ad = (appdata_s *)evas_object_data_get(obj, "ad");

	glViewport(0, 0, ad->glview_w, ad->glview_h);

	glClearColor(0.0f, 0.0f, 0.0f, 1.0f);
	glClear(GL_COLOR_BUFFER_BIT | GL_DEPTH_BUFFER_BIT);

	glBlendFunc(GL_SRC_ALPHA, GL_ONE_MINUS_SRC_ALPHA);
		glEnable(GL_BLEND);

	switch(current_state)
	{
	case CHOOSE_LANGUAGE:
		bg.Draw();
		US.Draw();
		UA.Draw();
		break;

	case MAIN_MENU:
		bg.Draw();
		options_btn.Draw();
		start_btn.Draw();
		fb_title.Draw();
		break;
	}

	glFlush();

	glDisable(GL_BLEND);
}

static void init_gl(Evas_Object *obj)
{
	appdata_s *ad = (appdata_s *)evas_object_data_get(obj, "ad");

	float Vertices[] = {
			-1.0f, -1.0f, 0.f, 0.0f, 0.0f,
			-1.0f, 1.0f, 0.f, 0.f, 1.0f,
			1.0f, 1.0f, 0.f, 1.f, 1.0f,
			1.0f, -1.0f, 0.f, 1.f, 0.0f
		};

	float Vertices1[] = {
			-0.8f, 0.2f, 0.f, 0.0f, 0.0f,
			-0.8f, 0.4f, 0.f, 0.f, 1.0f,
			-0.6f, 0.4f, 0.f, 1.f, 1.0f,
			-0.6f, 0.2f, 0.f, 1.f, 0.0f
		};

	float US_verticies[] = {
		-0.4f, -0.7f, 0.f, 0.0f, 0.0f,
		-0.4f, -0.2f, 0.f, 0.f, 1.0f,
		0.4f, -0.2f, 0.f, 1.f, 1.0f,
		0.4f, -0.7f, 0.f, 1.f, 0.0f
	};

	float UA_verticies[] = {
		-0.4f, 0.0f, 0.f, 0.0f, 0.0f,
		-0.4f, 0.5f, 0.f,      0.f, 1.0f,
		0.4f, 0.5f, 0.f, 1.f, 1.0f,
		0.4f, 0.0f, 0.f, 1.f, 0.0f
	};

	bg.Init("/opt/usr/apps/org.example.glviewshader6/shared/res/bg.tga", Vertices);

	US.Init("/opt/usr/apps/org.example.glviewshader6/shared/res/US.tga", US_verticies);
	UA.Init("/opt/usr/apps/org.example.glviewshader6/shared/res/UA.tga", UA_verticies);
}

static void
mouse_down_cb(void *data, Evas *e , Evas_Object *obj , void *event_info)
{
	appdata_s *ad = (appdata_s *)data;
	_Evas_Event_Mouse_Down *ev;
	ev = (_Evas_Event_Mouse_Down *)event_info;

	float px = (ev->canvas.x / ((float)ad->glview_w / 2.0)) -1.0;
	float py = -(ev->canvas.y / ((float)ad->glview_w / 2.0)) +1.0;

	switch(current_state)
	{
	case CHOOSE_LANGUAGE:
		if(px >= -0.4 && px <= 0.4
			&& py <= -0.2 && py >= -0.7
		)
		{
			current_state = MAIN_MENU;
			language = "US";
			InitLanguageButtons();
		}

		if(px >= -0.4 && px <= 0.4
			&& py >= 0.0 && py <= 0.5
		)
		{
			current_state = MAIN_MENU;
			language = "UA";
			InitLanguageButtons();
		}
		break;

	case MAIN_MENU:
		if(px >= -0.5 && px <= 0.5
			&& py <= -0.4 && py >= -0.8
		)
		{
			current_state = CHOOSE_LANGUAGE;
		}
		break;
	}
}

static void del_gl(Evas_Object *obj)
{
	/*appdata_s *ad = evas_object_data_get(obj, "ad");

	glDeleteBuffers(1, &ad->idx_vbo);
	glDeleteBuffers(1, &ad->idx_ibo);
	glDeleteShader(ad->vtx_shader);
	glDeleteShader(ad->fgmt_shader);
	glDeleteProgram(ad->program);

	evas_object_data_del((Evas_Object*) obj, "ad");*/
}

static void del_anim(void *data, Evas *evas, Evas_Object *obj, void *event_info)
{
	appdata_s *ad = (appdata_s *)data;
	ecore_animator_del(ad->ani);
}

static Eina_Bool anim(void *data)
{
	elm_glview_changed_set((Evas_Object*)data);
	return EINA_TRUE;
}


static void
win_delete_request_cb(void *data , Evas_Object *obj , void *event_info)
{
	ui_app_exit();
}

static void create_indicator(appdata_s *ad)
{
	elm_win_conformant_set(ad->win, EINA_TRUE);

	elm_win_indicator_mode_set(ad->win, ELM_WIN_INDICATOR_SHOW);
	elm_win_indicator_opacity_set(ad->win, ELM_WIN_INDICATOR_TRANSPARENT);

	ad->conform = elm_conformant_add(ad->win);
	evas_object_size_hint_weight_set(ad->conform, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	elm_win_resize_object_add(ad->win, ad->conform);
	evas_object_show(ad->conform);
}

static Evas_Object* add_win(const char *name)
{
	Evas_Object *win;


    // To use the Direct Rendering mode of GLView, set the same option values (depth, stencil, and MSAA)
    // to a rendering engine and a GLView object.
	elm_config_accel_preference_set("opengl:depth");
	win = elm_win_util_standard_add(name, "OpenGL example: Tea pot");

	if (!win)
		return NULL;

	if (elm_win_wm_rotation_supported_get(win)) {
		int rots[4] = { 0, 90, 180, 270 };
		elm_win_wm_rotation_available_rotations_set(win, rots, 4);
	}

	evas_object_show(win);

	return win;
}

static bool app_create(void *data)
{
	/* Hook to take necessary actions before main event loop starts
	 * Initialize UI resources and application's data
	 * If this function returns true, the main loop of application starts
	 * If this function returns false, the application is terminated. */

	Evas_Object *gl;
	appdata_s *ad = (appdata_s *)data;

	if (!data)
		return false;

	/* Create the window */
	ad->win = add_win(ad->name);

	if (!ad->win)
		return false;

	create_indicator(ad);
	evas_object_smart_callback_add(ad->win, "delete,request", win_delete_request_cb, NULL);
	eext_object_event_callback_add(ad->win, EEXT_CALLBACK_BACK, win_back_cb, ad);

	/* Create and initialize GLView */
	gl = elm_glview_add(ad->conform);
	ELEMENTARY_GLVIEW_GLOBAL_USE(gl);
	evas_object_size_hint_align_set(gl, EVAS_HINT_FILL, EVAS_HINT_FILL);
	evas_object_size_hint_weight_set(gl, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);

	/* Request a surface with a depth buffer
	 *
	 * To use the Direct Rendering mode, set the same option values (depth, stencil, and MSAA)
	 * to a rendering engine and a GLView object.
	 * You can set the option values to a rendering engine using the elm_config_accel_preference_set() function and
	 * to a GLView object using the elm_glview_mode_set() function.
	 * If the GLView object option values are bigger or higher than the rendering engine's,
	 * the Direct Rendering mode is disabled.
	 */
	elm_glview_mode_set(gl, (Elm_GLView_Mode)(ELM_GLVIEW_DEPTH | ELM_GLVIEW_DIRECT | ELM_GLVIEW_CLIENT_SIDE_ROTATION));

	/* The resize policy tells GLView what to do with the surface when it
	 * resizes. ELM_GLVIEW_RESIZE_POLICY_RECREATE will tell it to
	 * destroy the current surface and recreate it to the new size.
	 */
	elm_glview_resize_policy_set(gl, ELM_GLVIEW_RESIZE_POLICY_RECREATE);

	/* The render policy sets how GLView should render GL code.
	 * ELM_GLVIEW_RENDER_POLICY_ON_DEMAND will have the GL callback
	 * called only when the object is visible.
	 * ELM_GLVIEW_RENDER_POLICY_ALWAYS would cause the callback to be
	 * called even if the object were hidden.
	 */
	elm_glview_render_policy_set(gl, ELM_GLVIEW_RENDER_POLICY_ON_DEMAND);

	/* The initialize callback function gets registered here */
	elm_glview_init_func_set(gl, init_gl);

	/* The delete callback function gets registered here */
	elm_glview_del_func_set(gl, del_gl);

	/* The resize callback function gets registered here */
	elm_glview_resize_func_set(gl, resize_gl);

	/* The render callback function gets registered here */
	elm_glview_render_func_set(gl, draw_gl);

	/* Add the GLView to the conformant and show it */
	elm_object_content_set(ad->conform, gl);
	evas_object_show(gl);

	elm_object_focus_set(gl, EINA_TRUE);

	/* This adds an animator so that the app will regularly
	 * trigger updates of the GLView using elm_glview_changed_set().
	 *
	 * NOTE: If you delete GL, this animator will keep running trying to access
	 * GL so this animator needs to be deleted with ecore_animator_del().
	 */
	ad->ani = ecore_animator_add(anim, gl);
	evas_object_data_set(gl, "ad", ad);
	evas_object_event_callback_add(gl, EVAS_CALLBACK_DEL, del_anim, gl);

	evas_object_event_callback_add(gl, EVAS_CALLBACK_MOUSE_DOWN, mouse_down_cb, ad);

	evas_object_show(ad->win);

	/* Return true: the main loop will now start running */
	return true;
}

static void app_control(app_control_h app_control, void *data)
{
	/* Handle the launch request. */
}

static void app_pause(void *data)
{
	appdata_s *ad = (appdata_s *)data;
	ecore_animator_freeze(ad->ani);
}

static void app_resume(void *data)
{
	appdata_s *ad = (appdata_s *)data;
	ecore_animator_thaw(ad->ani);
}

static void app_terminate(void *data)
{
	/* Release all resources. */
}

int main(int argc, char *argv[])
{
	int ret = 0;
	appdata_s ad = { NULL, };
	ui_app_lifecycle_callback_s event_callback = {NULL,};

	current_state = CHOOSE_LANGUAGE;

	ad.name = "glviewshader6";

	event_callback.create = app_create;
	event_callback.terminate = app_terminate;
	event_callback.pause = app_pause;
	event_callback.resume = app_resume;
	event_callback.app_control = app_control;

	ret = ui_app_main(argc, argv, &event_callback, &ad);
	if (ret != APP_ERROR_NONE) {
		dlog_print(DLOG_ERROR, LOG_TAG, "The application failed to start, and returned %d", ret);
	}

	return ret;
}

