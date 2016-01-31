S/W Version Information
Model: Wearable-Emulator
Tizen-Version: 2.3.1
Build-Number: Tizen-2.3.1_Wearable-Emulator_20150902.2338
Build-Date: 2015.09.02 23:38:00

Crash Information
Process Name: glviewshader6
PID: 32293
Date: 2016-01-31 05:58:42+0900
Executable File Path: /opt/usr/apps/org.example.glviewshader6/bin/glviewshader6
Signal: 11
      (SIGSEGV)
      si_code: 2
      invalid permissions for mapped object
      si_addr = 0xb7725b2f

Register Information
gs  = 0x00000033, fs  = 0x00000000
es  = 0x0000007b, ds  = 0x0000007b
edi = 0xb8586dd8, esi = 0xb8559648
ebp = 0xbfe40c58, esp = 0xbfe40c20
eax = 0xb7725b2f, ebx = 0xb695de40
ecx = 0xb7725b2f, edx = 0x00000000
eip = 0xb686481e

Memory Information
MemTotal:      124 KB
MemFree:        33 KB
Buffers:        13 KB
Cached:     212968 KB
VmPeak:      64444 KB
VmSize:      64444 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       12548 KB
VmRSS:       12548 KB
VmData:       3988 KB
VmStk:         136 KB
VmExe:          28 KB
VmLib:       32416 KB
VmPTE:          60 KB
VmSwap:          0 KB

Maps Information
b3c03000 b3c27000 r-xp /usr/lib/edje/modules/elm/linux-gnu-i686-1.0.0/module.so
b3d90000 b3d93000 r-xp /usr/lib/libdri2.so.0.0.0
b3d94000 b3d9d000 r-xp /usr/lib/libtbm.so.1.0.0
b3da2000 b3db0000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnu-i686-1.7.99/module.so
b3db1000 b3dbc000 r-xp /usr/lib/libdrm.so.2.4.0
b3dbd000 b3dd6000 r-xp /usr/lib/yagl/libEGL.so.1.0
b3dd7000 b3e1f000 r-xp /usr/lib/yagl/libGLESv2.so.2.0
b3e22000 b3eac000 r-xp /usr/lib/evas/modules/engines/gl_x11/linux-gnu-i686-1.7.99/module.so
b3eb6000 b3eb9000 r-xp /usr/lib/libdrm_vigs.so.9.0.0
b3eba000 b3ffe000 r-xp /usr/lib/libcairo.so.2.11200.14
b4002000 b4023000 r-xp /usr/lib/libefl-extension.so.0.1.0
b4024000 b4058000 r-xp /opt/usr/apps/org.example.glviewshader6/bin/glviewshader6
b4059000 b4064000 r-xp /lib/libnss_files-2.13.so
b43c3000 b43ea000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b43eb000 b4410000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b4411000 b4531000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b4541000 b4577000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
b4579000 b457c000 r-xp /usr/lib/libiniparser.so.0
b457e000 b4588000 r-xp /usr/lib/libcapi-security-privilege-manager.so.0.0.3
b4589000 b4592000 r-xp /usr/lib/libappsvc.so.0.1.0
b4593000 b4596000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b4599000 b45a1000 r-xp /usr/lib/libxcb-render.so.0.0.0
b45a2000 b45a4000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b45a5000 b45ab000 r-xp /usr/lib/libogg.so.0.7.1
b45ac000 b45d7000 r-xp /usr/lib/libvorbis.so.0.4.3
b45d8000 b46c3000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b46d1000 b46d3000 r-xp /usr/lib/libXau.so.6.0.0
b46d4000 b4734000 r-xp /usr/lib/libssl.so.1.0.0
b4739000 b476a000 r-xp /usr/lib/libidn.so.11.5.44
b476b000 b477b000 r-xp /usr/lib/libcares.so.2.1.0
b477c000 b47e5000 r-xp /usr/lib/libsndfile.so.1.0.25
b47eb000 b47f5000 r-xp /usr/lib/libsensord-share.so
b47f6000 b481c000 r-xp /lib/libexpat.so.1.5.2
b481e000 b4845000 r-xp /usr/lib/libpng12.so.0.50.0
b4846000 b4866000 r-xp /usr/lib/libxcb.so.1.1.0
b4867000 b48d6000 r-xp /usr/lib/libcurl.so.4.3.0
b48d8000 b48e3000 r-xp /usr/lib/libethumb.so.1.7.99
b5e43000 b5f1b000 r-xp /usr/lib/libstdc++.so.6.0.16
b5f27000 b5f2a000 r-xp /usr/lib/libctxdata.so.0.0.0
b5f2b000 b5f41000 r-xp /usr/lib/libremix.so.0.0.0
b5f42000 b5f44000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
b5f45000 b5f71000 r-xp /usr/lib/liblua-5.1.so
b5f72000 b5f7c000 r-xp /usr/lib/libembryo.so.1.7.99
b5f7d000 b5fc3000 r-xp /usr/lib/libjpeg.so.8.0.2
b5fd4000 b5ff2000 r-xp /usr/lib/libsensor.so.1.1.0
b5ff4000 b6076000 r-xp /usr/lib/libpixman-1.so.0.28.2
b607b000 b60af000 r-xp /usr/lib/libfontconfig.so.1.5.0
b60b1000 b610c000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b610e000 b6124000 r-xp /usr/lib/libfribidi.so.0.3.1
b6125000 b61b1000 r-xp /usr/lib/libfreetype.so.6.11.3
b61b5000 b61b8000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
b61b9000 b61bf000 r-xp /usr/lib/libecore_ipc.so.1.7.99
b61c0000 b61c6000 r-xp /usr/lib/libecore_fb.so.1.7.99
b61c8000 b61d9000 r-xp /usr/lib/libXext.so.6.4.0
b61da000 b630e000 r-xp /usr/lib/libX11.so.6.3.0
b6312000 b6317000 r-xp /usr/lib/libXtst.so.6.1.0
b6318000 b6320000 r-xp /usr/lib/libXrender.so.1.3.0
b6321000 b632a000 r-xp /usr/lib/libXrandr.so.2.2.0
b632b000 b632d000 r-xp /usr/lib/libXinerama.so.1.0.0
b632e000 b633c000 r-xp /usr/lib/libXi.so.6.1.0
b633d000 b6341000 r-xp /usr/lib/libXfixes.so.3.1.0
b6342000 b6344000 r-xp /usr/lib/libXgesture.so.7.0.0
b6345000 b6347000 r-xp /usr/lib/libXcomposite.so.1.0.0
b6348000 b634a000 r-xp /usr/lib/libXdamage.so.1.1.0
b634b000 b6354000 r-xp /usr/lib/libXcursor.so.1.0.2
b6355000 b6380000 r-xp /usr/lib/libecore_con.so.1.7.99
b6382000 b638a000 r-xp /usr/lib/libecore_imf.so.1.7.99
b638b000 b6396000 r-xp /usr/lib/libethumb_client.so.1.7.99
b6397000 b639d000 r-xp /usr/lib/libefreet_mime.so.1.7.99
b639e000 b63bf000 r-xp /usr/lib/libefreet.so.1.7.99
b63c1000 b63cd000 r-xp /usr/lib/libedbus.so.1.7.99
b63ce000 b652d000 r-xp /usr/lib/libicuuc.so.51.1
b653b000 b6744000 r-xp /usr/lib/libicui18n.so.51.1
b674d000 b67ea000 r-xp /usr/lib/libedje.so.1.7.99
b67ec000 b67fd000 r-xp /usr/lib/libecore_input.so.1.7.99
b67fe000 b6805000 r-xp /usr/lib/libecore_file.so.1.7.99
b6806000 b682c000 r-xp /usr/lib/libeet.so.1.7.99
b6835000 b695d000 r-xp /usr/lib/libevas.so.1.7.99
b697a000 b69ad000 r-xp /usr/lib/libecore_evas.so.1.7.99
b69af000 b69f3000 r-xp /usr/lib/libecore_x.so.1.7.99
b69f5000 b6bef000 r-xp /usr/lib/libelementary.so.1.7.99
b6c00000 b6c06000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b6c07000 b6c0b000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b6c0f000 b6c10000 r-xp /usr/lib/libjournal.so.0.1.0
b6c11000 b6d59000 r-xp /usr/lib/libxml2.so.2.7.8
b6d60000 b6d73000 r-xp /lib/libresolv-2.13.so
b6d77000 b6d94000 r-xp /lib/libz.so.1.2.5
b6d95000 b6d98000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
b6d99000 b6d9e000 r-xp /usr/lib/libffi.so.5.0.10
b6d9f000 b6da0000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
b6da2000 b6da6000 r-xp /lib/libattr.so.1.1.0
b6da7000 b6fb9000 r-xp /usr/lib/libcrypto.so.1.0.0
b6fd4000 b6ff5000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b6ff6000 b701e000 r-xp /lib/libm-2.13.so
b7020000 b707b000 r-xp /usr/lib/libeina.so.1.7.99
b707e000 b7089000 r-xp /usr/lib/libvconf.so.0.2.45
b708a000 b708d000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b708e000 b70dc000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
b70dd000 b723e000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
b7242000 b7249000 r-xp /lib/librt-2.13.so
b724c000 b7253000 r-xp /usr/lib/libcapi-base-common.so.0.1.9
b7255000 b726f000 r-xp /lib/libgcc_s-4.6.4.so.1
b7270000 b7278000 r-xp /lib/libcrypt-2.13.so
b72a1000 b72a5000 r-xp /lib/libcap.so.2.21
b72a6000 b72a8000 r-xp /usr/lib/libiri.so
b72aa000 b72d6000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b72d7000 b72f7000 r-xp /usr/lib/libecore.so.1.7.99
b7306000 b730f000 r-xp /usr/lib/libxdgmime.so.1.1.0
b7310000 b7433000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
b7434000 b7447000 r-xp /usr/lib/libail.so.0.1.0
b7449000 b746e000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b746f000 b7479000 r-xp /lib/libunwind.so.8.0.1
b7483000 b75f4000 r-xp /lib/libc-2.13.so
b75fa000 b7644000 r-xp /usr/lib/libdbus-1.so.3.7.2
b7645000 b764a000 r-xp /usr/lib/libbundle.so.0.1.22
b764b000 b764e000 r-xp /lib/libdl-2.13.so
b7651000 b7656000 r-xp /usr/lib/libsmack.so.1.0.0
b7657000 b76ff000 r-xp /usr/lib/libsqlite3.so.0.8.6
b7702000 b771c000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b771d000 b7734000 r-xp /lib/libpthread-2.13.so
b7738000 b773b000 r-xp /usr/lib/libdlog.so.0.0.0
b773c000 b774c000 r-xp /usr/lib/libaul.so.0.1.0
b774e000 b7754000 r-xp /usr/lib/libappcore-common.so.1.1
b7755000 b775a000 r-xp /usr/lib/libappcore-efl.so.1.1
b775c000 b7761000 r-xp /usr/lib/libsys-assert.so
b7764000 b7782000 r-xp /lib/ld-2.13.so
b7782000 b7783000 r-xp [vdso]
b7785000 b778c000 r-xp /usr/bin/launchpad_preloading_preinitializing_daemon
End of Maps Information

Callstack Information (PID:32293)
Call Stack Count: 21
 0: evas_object_image_size_get + 0x4e (0xb686481e) [/usr/lib/libevas.so.1] + 0x2f81e
 1: load_texture + 0xdc (0xb4025f8c) [/opt/usr/apps/org.example.glviewshader6/bin/glviewshader6] + 0x1f8c
 2: init_shaders + 0x238 (0xb4027308) [/opt/usr/apps/org.example.glviewshader6/bin/glviewshader6] + 0x3308
 3: init_gl + 0x74 (0xb4026ae4) [/opt/usr/apps/org.example.glviewshader6/bin/glviewshader6] + 0x2ae4
 4: (0xb6acb307) [/usr/lib/libelementary.so.1] + 0xd6307
 5: (0xb3e2d42d) [/usr/lib/evas/modules/engines/gl_x11/linux-gnu-i686-1.7.99/module.so] + 0xb42d
 6: (0xb68631c1) [/usr/lib/libevas.so.1] + 0x2e1c1
 7: (0xb68b0635) [/usr/lib/libevas.so.1] + 0x7b635
 8: (0xb68b4305) [/usr/lib/libevas.so.1] + 0x7f305
 9: (0xb698f8d7) [/usr/lib/libecore_evas.so.1] + 0x158d7
10: ecore_evas_manual_render + 0x5d (0xb698a5cd) [/usr/lib/libecore_evas.so.1] + 0x105cd
11: (0xb698e879) [/usr/lib/libecore_evas.so.1] + 0x14879
12: (0xb72e3852) [/usr/lib/libecore.so.1] + 0xc852
13: (0xb72e52fd) [/usr/lib/libecore.so.1] + 0xe2fd
14: ecore_main_loop_begin + 0x3f (0xb72e59cf) [/usr/lib/libecore.so.1] + 0xe9cf
15: elm_run + 0x17 (0xb6afc867) [/usr/lib/libelementary.so.1] + 0x107867
16: appcore_efl_main + 0x3d1 (0xb7757e91) [/usr/lib/libappcore-efl.so.1] + 0x2e91
17: ui_app_main + 0x130 (0xb6c09500) [/usr/lib/libcapi-appfw-application.so.0] + 0x2500
18: main + 0x152 (0xb40263d2) [/opt/usr/apps/org.example.glviewshader6/bin/glviewshader6] + 0x23d2
19: rotate_xyz + 0xc1 (0xb77885b1) [/opt/usr/apps/org.example.glviewshader6/bin/glviewshader6] + 0xb77885b1
20: __libc_start_main + 0xf3 (0xb749c0f3) [/lib/libc.so.6] + 0x190f3
End of Call Stack

Package Information
Package Name: org.example.glviewshader6
Package ID : org.example.glviewshader6
Version: 1.0.1
Package Type: rpm
App Name: glviewshader6
App ID: org.example.glviewshader6
Type: capp
Categories: 

Latest Debug Message Information
--------- beginning of /dev/log_main
ath
01-31 05:58:37.172+0900 E/PKGMGR_PLUGIN(32233): pkgmgr_parser_plugin.c: __process_each_plugin(827) > (plugin_info->lib_handle == NULL) dlopen is failed lib_path
01-31 05:58:37.172+0900 E/PKGMGR_PLUGIN(32233): pkgmgr_parser_plugin.c: __process_each_plugin(827) > (plugin_info->lib_handle == NULL) dlopen is failed lib_path
01-31 05:58:37.172+0900 E/PKGMGR_PLUGIN(32233): pkgmgr_parser_plugin.c: __process_each_plugin(827) > (plugin_info->lib_handle == NULL) dlopen is failed lib_path
01-31 05:58:37.182+0900 D/PKGMGR_PLUGIN(32233): pkgmgr_parser_plugin.c: __process_each_plugin(830) > [SECURE_LOG] PLUGIN_PRE_PROCESS : [watch-application] result=[0]
01-31 05:58:37.182+0900 D/PKGMGR_PLUGIN(32233): pkgmgr_parser_plugin.c: __process_each_plugin(841) > [SECURE_LOG] PLUGIN_POST_PROCESS : [watch-application] result=[0]
01-31 05:58:37.182+0900 D/PKGMGR_PLUGIN(32233): pkgmgr_parser_plugin.c: __process_plugin_db(801) > [SECURE_LOG] pkgid [org.example.glviewshader6] plugin[0x0] deleted
01-31 05:58:37.192+0900 D/PKGMGR_PLUGIN(32233): pkgmgr_parser_plugin.c: __process_plugin_db(817) > [SECURE_LOG] pkgid [org.example.glviewshader6] plugin[0x0] inserted
01-31 05:58:37.192+0900 D/AIL     (32233): ail_filter.c: ail_filter_count_appinfo(306) > No filter exists. All records are retreived
01-31 05:58:37.192+0900 E/AIL     (32233): ail_db.c: db_exec(244) > Cannot execute because table app_info already exists
01-31 05:58:37.192+0900 E/AIL     (32233): ail_db.c: db_exec(245) > query - CREATE TABLE app_info (package TEXT PRIMARY KEY, exec TEXT DEFAULT 'No Exec', name TEXT DEFAULT 'No Name', type TEXT DEFAULT 'Application', icon TEXT DEFAULT 'No Icon', categories TEXT, version TEXT, mimetype TEXT, x_slp_service TEXT, x_slp_packagetype TEXT, x_slp_packagecategories TEXT, x_slp_packageid TEXT, x_slp_uri TEXT, x_slp_svc TEXT, x_slp_exe_path TEXT, x_slp_appid TEXT, x_slp_pkgid TEXT, x_slp_domain TEXT, x_slp_submodemainid TEXT, x_slp_installedstorage TEXT, x_slp_baselayoutwidth INTEGER DEFAULT 0, x_slp_installedtime INTEGER DEFAULT 0, nodisplay INTEGER DEFAULT 0, x_slp_taskmanage INTEGER DEFAULT 1, x_slp_multiple INTEGER DEFAULT 0, x_slp_removable INTEGER DEFAULT 1, x_slp_ishorizontalscale INTEGER DEFAULT 0, x_slp_enabled INTEGER DEFAULT 1, x_slp_submode INTEGER DEFAULT 0, desktop TEXT UNIQUE NOT NULL);
01-31 05:58:37.192+0900 E/AIL     (32233): ail_desktop.c: _create_table(1200) > (ret != AIL_ERROR_OK) -> _create_table() return
01-31 05:58:37.192+0900 D/AIL     (32233): ail_desktop.c: ail_desktop_add(1595) > Cannot create a table. Maybe there is already a table.
01-31 05:58:37.192+0900 D/AIL     (32233): ail_desktop.c: _read_desktop_info(967) > Read (org.example.glviewshader6).
01-31 05:58:37.202+0900 D/AIL     (32233): ail_desktop.c: _insert_desktop_info(1314) > Add (org.example.glviewshader6).
01-31 05:58:37.202+0900 D/AIL     (32233): ail_desktop.c: _send_db_done_noti(1518) > Noti : create:org.example.glviewshader6
01-31 05:58:37.202+0900 D/PKGMGR_PARSER(32233): pkgmgr_parser.c: pkgmgr_parser_parse_manifest_for_installation(2219) > Creating desktop file Success
01-31 05:58:37.202+0900 D/PKGMGR_PARSER(32233): pkgmgr_parser.c: pkgmgr_parser_parse_manifest_for_installation(2224) > Free Done
01-31 05:58:37.202+0900 D/rpm-installer(32233): coretpk-installer.c: _coretpk_installer_package_install(2212) > manifest parsing done successfully.
01-31 05:58:37.202+0900 D/rpm-installer(32233): rpm-vconf-intf.c: _ri_broadcast_status_notification(188) > pkgid=[org.example.glviewshader6], key=[install_percent], val=[60]
01-31 05:58:37.202+0900 D/PKGMGR  (13163): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] /opt/usr/apps/tmp/org.example.glviewshader6-1.0.1-i386.tpk_1784818984 / coretpk / org.example.glviewshader6 / install_percent / 60
01-31 05:58:37.202+0900 D/PKGMGR  (13163): pkgmgr.c: __status_callback(440) > [SECURE_LOG] __status_callback() req_id[/opt/usr/apps/tmp/org.example.glviewshader6-1.0.1-i386.tpk_1784818984] pkg_type[coretpk] pkgid[org.example.glviewshader6]key[install_percent] val[60]
01-31 05:58:37.202+0900 D/ADD_VIEWER(13163): add-viewer_pkgmgr.c: progress_cb(385) > [SECURE_LOG] [org.example.glviewshader6] 60
01-31 05:58:37.202+0900 D/PKGMGR  (13163): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
01-31 05:58:37.202+0900 D/PKGMGR  (13163): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
01-31 05:58:37.202+0900 D/PKGMGR  (13163): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] /opt/usr/apps/tmp/org.example.glviewshader6-1.0.1-i386.tpk_1784818984 / coretpk / org.example.glviewshader6 / install_percent / 60
01-31 05:58:37.202+0900 D/PKGMGR  (13163): pkgmgr.c: __status_callback(440) > [SECURE_LOG] __status_callback() req_id[/opt/usr/apps/tmp/org.example.glviewshader6-1.0.1-i386.tpk_1784818984] pkg_type[coretpk] pkgid[org.example.glviewshader6]key[install_percent] val[60]
01-31 05:58:37.202+0900 D/W_HOME  (13163): clock_event.c: _pkgmgr_event_cb(123) > pkg:org.example.glviewshader6 key:install_percent val:60
01-31 05:58:37.202+0900 D/PKGMGR  (13163): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
01-31 05:58:37.202+0900 D/PKGMGR  (13163): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
01-31 05:58:37.202+0900 D/PKGMGR  (13163): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] /opt/usr/apps/tmp/org.example.glviewshader6-1.0.1-i386.tpk_1784818984 / coretpk / org.example.glviewshader6 / install_percent / 60
01-31 05:58:37.202+0900 D/PKGMGR  (13163): pkgmgr.c: __status_callback(440) > [SECURE_LOG] __status_callback() req_id[/opt/usr/apps/tmp/org.example.glviewshader6-1.0.1-i386.tpk_1784818984] pkg_type[coretpk] pkgid[org.example.glviewshader6]key[install_percent] val[60]
01-31 05:58:37.202+0900 D/APPS    (13163): pkgmgr.c: _pkgmgr_cb(704) >  pkgmgr request [install_percent:60] for org.example.glviewshader6
01-31 05:58:37.202+0900 D/APPS    (13163): pkgmgr.c: _install_percent(469) >  package(org.example.glviewshader6) with 60
01-31 05:58:37.202+0900 D/PKGMGR  (13163): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
01-31 05:58:37.202+0900 D/PKGMGR  (13163): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
01-31 05:58:37.202+0900 D/PKGMGR  ( 2391): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] /opt/usr/apps/tmp/org.example.glviewshader6-1.0.1-i386.tpk_1784818984 / coretpk / org.example.glviewshader6 / install_percent / 60
01-31 05:58:37.202+0900 D/PKGMGR  ( 2391): pkgmgr.c: __status_callback(440) > [SECURE_LOG] __status_callback() req_id[/opt/usr/apps/tmp/org.example.glviewshader6-1.0.1-i386.tpk_1784818984] pkg_type[coretpk] pkgid[org.example.glviewshader6]key[install_percent] val[60]
01-31 05:58:37.202+0900 D/PKGMGR  ( 2391): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
01-31 05:58:37.202+0900 D/PKGMGR  ( 2391): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
01-31 05:58:37.202+0900 D/PKGMGR  ( 2261): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] /opt/usr/apps/tmp/org.example.glviewshader6-1.0.1-i386.tpk_1784818984 / coretpk / org.example.glviewshader6 / install_percent / 60
01-31 05:58:37.202+0900 D/PKGMGR  ( 2261): pkgmgr.c: __status_callback(440) > [SECURE_LOG] __status_callback() req_id[/opt/usr/apps/tmp/org.example.glviewshader6-1.0.1-i386.tpk_1784818984] pkg_type[coretpk] pkgid[org.example.glviewshader6]key[install_percent] val[60]
01-31 05:58:37.202+0900 D/DATA_PROVIDER_MASTER( 2261): pkgmgr.c: progress_cb(374) > [SECURE_LOG] [org.example.glviewshader6] 60
01-31 05:58:37.202+0900 D/PKGMGR  ( 2261): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
01-31 05:58:37.202+0900 D/PKGMGR  ( 2261): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
01-31 05:58:37.202+0900 D/PKGMGR  ( 2262): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] /opt/usr/apps/tmp/org.example.glviewshader6-1.0.1-i386.tpk_1784818984 / coretpk / org.example.glviewshader6 / install_percent / 60
01-31 05:58:37.202+0900 D/PKGMGR  ( 2262): pkgmgr.c: __status_callback(440) > [SECURE_LOG] __status_callback() req_id[/opt/usr/apps/tmp/org.example.glviewshader6-1.0.1-i386.tpk_1784818984] pkg_type[coretpk] pkgid[org.example.glviewshader6]key[install_percent] val[60]
01-31 05:58:37.202+0900 D/PKGMGR  ( 2262): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
01-31 05:58:37.202+0900 D/PKGMGR  ( 2262): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
01-31 05:58:37.202+0900 D/PKGMGR  ( 2221): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] /opt/usr/apps/tmp/org.example.glviewshader6-1.0.1-i386.tpk_1784818984 / coretpk / org.example.glviewshader6 / install_percent / 60
01-31 05:58:37.202+0900 D/PKGMGR  ( 2221): pkgmgr.c: __status_callback(440) > [SECURE_LOG] __status_callback() req_id[/opt/usr/apps/tmp/org.example.glviewshader6-1.0.1-i386.tpk_1784818984] pkg_type[coretpk] pkgid[org.example.glviewshader6]key[install_percent] val[60]
01-31 05:58:37.202+0900 D/PKGMGR  ( 2221): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
01-31 05:58:37.202+0900 D/PKGMGR  ( 2221): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
01-31 05:58:37.212+0900 E/PKGMGR_CERT(32233): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(438) > Transaction Begin
01-31 05:58:37.212+0900 E/PKGMGR_CERT(32233): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(507) > Id:Count = 1 5
01-31 05:58:37.212+0900 E/PKGMGR_CERT(32233): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(507) > Id:Count = 2 5
01-31 05:58:37.212+0900 E/PKGMGR_CERT(32233): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(507) > Id:Count = 11 1
01-31 05:58:37.212+0900 E/PKGMGR_CERT(32233): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(507) > Id:Count = 8 1
01-31 05:58:37.212+0900 E/PKGMGR_CERT(32233): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(507) > Id:Count = 9 1
01-31 05:58:37.212+0900 E/PKGMGR_CERT(32233): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(507) > Id:Count = 10 1
01-31 05:58:37.212+0900 E/PKGMGR_CERT(32233): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(587) > Transaction Commit and End
01-31 05:58:37.212+0900 E/rpm-installer(32233): coretpk-installer.c: _coretpk_installer_make_directory(1517) > mkdir failed. appdir=[/usr/apps/org.example.glviewshader6/shared], errno=[2][No such file or directory]
01-31 05:58:37.212+0900 E/rpm-installer(32233): coretpk-installer.c: _coretpk_installer_apply_directory_policy(1150) > skip! empty dirpath=[/usr/apps/org.example.glviewshader6/shared]
01-31 05:58:37.212+0900 E/rpm-installer(32233): coretpk-installer.c: _coretpk_installer_apply_directory_policy(1150) > skip! empty dirpath=[/usr/apps/org.example.glviewshader6/shared/res]
01-31 05:58:37.212+0900 E/rpm-installer(32233): coretpk-installer.c: _coretpk_installer_apply_file_policy(1135) > skip! empty filepath=[/usr/apps/org.example.glviewshader6/tizen-manifest.xml]
01-31 05:58:37.212+0900 E/rpm-installer(32233): coretpk-installer.c: _coretpk_installer_apply_file_policy(1135) > skip! empty filepath=[/usr/apps/org.example.glviewshader6/author-signature.xml]
01-31 05:58:37.212+0900 E/rpm-installer(32233): coretpk-installer.c: _coretpk_installer_apply_file_policy(1135) > skip! empty filepath=[/usr/apps/org.example.glviewshader6/signature1.xml]
01-31 05:58:37.212+0900 E/rpm-installer(32233): coretpk-installer.c: _coretpk_installer_apply_file_policy(1135) > skip! empty filepath=[/usr/share/packages/org.example.glviewshader6.xml]
01-31 05:58:37.212+0900 D/rpm-installer(32233): coretpk-installer.c: _coretpk_installer_make_directory_for_ext(1321) > Exist shared/data folder (path:[/opt/usr/apps/org.example.glviewshader6/shared/data])
01-31 05:58:37.232+0900 D/rpm-installer(32233): rpm-installer-privilege.c: _ri_privilege_register_package(64) > [smack] app_install(org.example.glviewshader6), result=[0]
01-31 05:58:37.232+0900 D/rpm-installer(32233): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.example.glviewshader6, /opt/usr/apps/org.example.glviewshader6, 5, _), result=[0]
01-31 05:58:37.232+0900 D/rpm-installer(32233): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.example.glviewshader6, /opt/usr/apps/org.example.glviewshader6/shared, 5, _), result=[0]
01-31 05:58:37.232+0900 D/rpm-installer(32233): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.example.glviewshader6, /opt/usr/apps/org.example.glviewshader6/shared/res, 5, _), result=[0]
01-31 05:58:37.252+0900 D/rpm-installer(32233): rpm-installer-privilege.c: _ri_privilege_setup_path(120) > [smack] app_setup_path(org.example.glviewshader6, /opt/usr/apps/org.example.glviewshader6/shared/data, 2), result=[0]
01-31 05:58:37.252+0900 D/rpm-installer(32233): coretpk-installer.c: _coretpk_installer_get_group_id(1797) > encoding done, len=[28]
01-31 05:58:37.252+0900 D/rpm-installer(32233): coretpk-installer.c: _coretpk_installer_apply_smack(1905) > groupid = [ZKPYOlSM1VPVR#zL0RCSDwxO6t4=] for shared/trusted.
01-31 05:58:37.262+0900 D/rpm-installer(32233): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.example.glviewshader6, /opt/usr/apps/org.example.glviewshader6/shared/trusted, 1, ZKPYOlSM1VPVR#zL0RCSDwxO6t4=), result=[0]
01-31 05:58:37.262+0900 D/rpm-installer(32233): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.example.glviewshader6, /opt/usr/apps/org.example.glviewshader6/bin, 0, org.example.glviewshader6), result=[0]
01-31 05:58:37.262+0900 D/rpm-installer(32233): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.example.glviewshader6, /opt/usr/apps/org.example.glviewshader6/data, 0, org.example.glviewshader6), result=[0]
01-31 05:58:37.262+0900 D/rpm-installer(32233): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.example.glviewshader6, /opt/usr/apps/org.example.glviewshader6/lib, 0, org.example.glviewshader6), result=[0]
01-31 05:58:37.262+0900 D/rpm-installer(32233): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.example.glviewshader6, /opt/usr/apps/org.example.glviewshader6/res, 0, org.example.glviewshader6), result=[0]
01-31 05:58:37.262+0900 D/rpm-installer(32233): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.example.glviewshader6, /opt/usr/apps/org.example.glviewshader6/cache, 0, org.example.glviewshader6), result=[0]
01-31 05:58:37.262+0900 D/rpm-installer(32233): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.example.glviewshader6, /opt/usr/apps/org.example.glviewshader6/tizen-manifest.xml, 0, org.example.glviewshader6), result=[0]
01-31 05:58:37.262+0900 D/rpm-installer(32233): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.example.glviewshader6, /opt/usr/apps/org.example.glviewshader6/author-signature.xml, 0, org.example.glviewshader6), result=[0]
01-31 05:58:37.262+0900 D/rpm-installer(32233): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.example.glviewshader6, /opt/usr/apps/org.example.glviewshader6/signature1.xml, 0, org.example.glviewshader6), result=[0]
01-31 05:58:37.262+0900 D/rpm-installer(32233): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.example.glviewshader6, /opt/share/packages/org.example.glviewshader6.xml, 0, org.example.glviewshader6), result=[0]
01-31 05:58:37.262+0900 D/rpm-installer(32233): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.example.glviewshader6, /opt/storage/sdcard/apps/org.example.glviewshader6, 5, _), result=[0]
01-31 05:58:37.262+0900 D/rpm-installer(32233): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.example.glviewshader6, /opt/storage/sdcard/apps/org.example.glviewshader6/data, 0, org.example.glviewshader6), result=[0]
01-31 05:58:37.262+0900 D/rpm-installer(32233): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.example.glviewshader6, /opt/storage/sdcard/apps/org.example.glviewshader6/cache, 0, org.example.glviewshader6), result=[0]
01-31 05:58:37.262+0900 D/rpm-installer(32233): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.example.glviewshader6, /opt/storage/sdcard/apps/org.example.glviewshader6/shared, 5, _), result=[0]
01-31 05:58:37.282+0900 D/rpm-installer(32233): rpm-installer-privilege.c: _ri_privilege_setup_path(120) > [smack] app_setup_path(org.example.glviewshader6, /opt/storage/sdcard/apps/org.example.glviewshader6/shared/data, 2), result=[0]
01-31 05:58:37.282+0900 D/rpm-installer(32233): coretpk-installer.c: _coretpk_installer_get_pkgfile_info(1010) > switched to /opt/usr/rpminstaller
01-31 05:58:37.282+0900 D/rpm-installer(32233): coretpk-installer.c: _coretpk_installer_load_directory(869) > loading manifest files, directory=[/opt/usr/rpminstaller]
01-31 05:58:37.282+0900 D/rpm-installer(32233): coretpk-installer.c: _coretpk_installer_load_directory(889) > manifest=[tizen-manifest.xml], path=[/opt/usr/rpminstaller/tizen-manifest.xml]
01-31 05:58:37.282+0900 D/rpm-installer(32233): coretpk-installer.c: _coretpk_installer_get_pkgfile_info(1032) > manifest file=[/opt/usr/rpminstaller/tizen-manifest.xml]
01-31 05:58:37.282+0900 D/rpm-installer(32233): coretpk-installer.c: _coretpk_installer_get_pkgfile_info(1066) > pkgid=[org.example.glviewshader6], version=[1.0.1], api-version=[2.3.1]
01-31 05:58:37.282+0900 E/rpm-installer(32233): coretpk-parser.c: _coretpk_parser_is_widget(773) > (ret == 1) NodeSet is empty. (//*[name() = 'manifest']/*[name()='widget-application'])
01-31 05:58:37.282+0900 D/rpm-installer(32233): rpm-installer-util.c: _rpm_delete_dir(261) > delete_dir=[/opt/usr/rpminstaller]
01-31 05:58:37.292+0900 D/rpm-installer(32233): rpm-installer-privilege.c: _ri_privilege_set_package_version(74) > [smack] app[org.example.glviewshader6] version set to [2.3.1] result=[0]
01-31 05:58:37.292+0900 D/rpm-installer(32233): coretpk-installer.c: _coretpk_installer_package_install(2249) > api-version fot privilege has done successfully.
01-31 05:58:37.302+0900 D/rpm-installer(32233): rpm-installer-privilege.c: __ri_privilege_perm_begin(44) > [smack] perm_begin, result=[0]
01-31 05:58:37.302+0900 D/rpm-installer(32233): rpm-installer-privilege.c: _ri_privilege_enable_permissions(107) > [smack] app_enable_permissions(org.example.glviewshader6, 7), result=[0]
01-31 05:58:37.312+0900 D/rpm-installer(32233): rpm-installer-privilege.c: __ri_privilege_perm_end(54) > [smack] perm_end, result=[0]
01-31 05:58:37.312+0900 D/rpm-installer(32233): coretpk-installer.c: _coretpk_installer_package_install(2259) > permission applying done successfully.
01-31 05:58:37.312+0900 D/rpm-installer(32233): rpm-vconf-intf.c: _ri_broadcast_status_notification(188) > pkgid=[org.example.glviewshader6], key=[install_percent], val=[100]
01-31 05:58:37.312+0900 D/PKGMGR  (13163): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] /opt/usr/apps/tmp/org.example.glviewshader6-1.0.1-i386.tpk_1784818984 / coretpk / org.example.glviewshader6 / install_percent / 100
01-31 05:58:37.312+0900 D/PKGMGR  (13163): pkgmgr.c: __status_callback(440) > [SECURE_LOG] __status_callback() req_id[/opt/usr/apps/tmp/org.example.glviewshader6-1.0.1-i386.tpk_1784818984] pkg_type[coretpk] pkgid[org.example.glviewshader6]key[install_percent] val[100]
01-31 05:58:37.312+0900 D/ADD_VIEWER(13163): add-viewer_pkgmgr.c: progress_cb(385) > [SECURE_LOG] [org.example.glviewshader6] 100
01-31 05:58:37.312+0900 D/PKGMGR  (13163): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
01-31 05:58:37.312+0900 D/PKGMGR  (13163): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
01-31 05:58:37.312+0900 D/PKGMGR  (13163): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] /opt/usr/apps/tmp/org.example.glviewshader6-1.0.1-i386.tpk_1784818984 / coretpk / org.example.glviewshader6 / install_percent / 100
01-31 05:58:37.312+0900 D/PKGMGR  (13163): pkgmgr.c: __status_callback(440) > [SECURE_LOG] __status_callback() req_id[/opt/usr/apps/tmp/org.example.glviewshader6-1.0.1-i386.tpk_1784818984] pkg_type[coretpk] pkgid[org.example.glviewshader6]key[install_percent] val[100]
01-31 05:58:37.312+0900 D/W_HOME  (13163): clock_event.c: _pkgmgr_event_cb(123) > pkg:org.example.glviewshader6 key:install_percent val:100
01-31 05:58:37.312+0900 D/PKGMGR  (13163): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
01-31 05:58:37.312+0900 D/PKGMGR  (13163): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
01-31 05:58:37.312+0900 D/PKGMGR  (13163): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] /opt/usr/apps/tmp/org.example.glviewshader6-1.0.1-i386.tpk_1784818984 / coretpk / org.example.glviewshader6 / install_percent / 100
01-31 05:58:37.312+0900 D/PKGMGR  (13163): pkgmgr.c: __status_callback(440) > [SECURE_LOG] __status_callback() req_id[/opt/usr/apps/tmp/org.example.glviewshader6-1.0.1-i386.tpk_1784818984] pkg_type[coretpk] pkgid[org.example.glviewshader6]key[install_percent] val[100]
01-31 05:58:37.312+0900 D/APPS    (13163): pkgmgr.c: _pkgmgr_cb(704) >  pkgmgr request [install_percent:100] for org.example.glviewshader6
01-31 05:58:37.312+0900 D/APPS    (13163): pkgmgr.c: _install_percent(469) >  package(org.example.glviewshader6) with 100
01-31 05:58:37.312+0900 D/PKGMGR  (13163): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
01-31 05:58:37.312+0900 D/PKGMGR  (13163): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
01-31 05:58:37.312+0900 D/PKGMGR  ( 2391): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] /opt/usr/apps/tmp/org.example.glviewshader6-1.0.1-i386.tpk_1784818984 / coretpk / org.example.glviewshader6 / install_percent / 100
01-31 05:58:37.312+0900 D/PKGMGR  ( 2391): pkgmgr.c: __status_callback(440) > [SECURE_LOG] __status_callback() req_id[/opt/usr/apps/tmp/org.example.glviewshader6-1.0.1-i386.tpk_1784818984] pkg_type[coretpk] pkgid[org.example.glviewshader6]key[install_percent] val[100]
01-31 05:58:37.312+0900 D/PKGMGR  ( 2391): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
01-31 05:58:37.312+0900 D/PKGMGR  ( 2391): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
01-31 05:58:37.312+0900 D/PKGMGR  ( 2261): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] /opt/usr/apps/tmp/org.example.glviewshader6-1.0.1-i386.tpk_1784818984 / coretpk / org.example.glviewshader6 / install_percent / 100
01-31 05:58:37.312+0900 D/PKGMGR  ( 2261): pkgmgr.c: __status_callback(440) > [SECURE_LOG] __status_callback() req_id[/opt/usr/apps/tmp/org.example.glviewshader6-1.0.1-i386.tpk_1784818984] pkg_type[coretpk] pkgid[org.example.glviewshader6]key[install_percent] val[100]
01-31 05:58:37.312+0900 D/DATA_PROVIDER_MASTER( 2261): pkgmgr.c: progress_cb(374) > [SECURE_LOG] [org.example.glviewshader6] 100
01-31 05:58:37.312+0900 D/PKGMGR  ( 2261): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
01-31 05:58:37.312+0900 D/PKGMGR  ( 2261): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
01-31 05:58:37.312+0900 D/PKGMGR  ( 2262): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] /opt/usr/apps/tmp/org.example.glviewshader6-1.0.1-i386.tpk_1784818984 / coretpk / org.example.glviewshader6 / install_percent / 100
01-31 05:58:37.312+0900 D/PKGMGR  ( 2262): pkgmgr.c: __status_callback(440) > [SECURE_LOG] __status_callback() req_id[/opt/usr/apps/tmp/org.example.glviewshader6-1.0.1-i386.tpk_1784818984] pkg_type[coretpk] pkgid[org.example.glviewshader6]key[install_percent] val[100]
01-31 05:58:37.312+0900 D/PKGMGR  ( 2262): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
01-31 05:58:37.312+0900 D/PKGMGR  ( 2262): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
01-31 05:58:37.312+0900 D/PKGMGR  ( 2221): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] /opt/usr/apps/tmp/org.example.glviewshader6-1.0.1-i386.tpk_1784818984 / coretpk / org.example.glviewshader6 / install_percent / 100
01-31 05:58:37.312+0900 D/PKGMGR  ( 2221): pkgmgr.c: __status_callback(440) > [SECURE_LOG] __status_callback() req_id[/opt/usr/apps/tmp/org.example.glviewshader6-1.0.1-i386.tpk_1784818984] pkg_type[coretpk] pkgid[org.example.glviewshader6]key[install_percent] val[100]
01-31 05:58:37.312+0900 D/PKGMGR  ( 2221): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
01-31 05:58:37.312+0900 D/PKGMGR  ( 2221): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
01-31 05:58:37.312+0900 D/rpm-installer(32233): coretpk-installer.c: _coretpk_installer_package_install(2289) > install status is [2].
01-31 05:58:37.312+0900 D/rpm-installer(32233): coretpk-installer.c: __post_install_for_mmc(311) > Installed storage is internal.
01-31 05:58:37.312+0900 D/rpm-installer(32233): coretpk-installer.c: _coretpk_installer_package_install(2301) > _coretpk_installer_package_install is done.
01-31 05:58:37.312+0900 D/rpm-installer(32233): rpm-vconf-intf.c: _ri_broadcast_status_notification(196) > pkgid=[org.example.glviewshader6], key=[end], val=[ok]
01-31 05:58:37.312+0900 D/PKGMGR  (13163): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] /opt/usr/apps/tmp/org.example.glviewshader6-1.0.1-i386.tpk_1784818984 / coretpk / org.example.glviewshader6 / end / ok
01-31 05:58:37.312+0900 D/PKGMGR  (13163): pkgmgr.c: __status_callback(440) > [SECURE_LOG] __status_callback() req_id[/opt/usr/apps/tmp/org.example.glviewshader6-1.0.1-i386.tpk_1784818984] pkg_type[coretpk] pkgid[org.example.glviewshader6]key[end] val[ok]
01-31 05:58:37.312+0900 D/ADD_VIEWER(13163): add-viewer_pkgmgr.c: end_cb(420) > [SECURE_LOG] [org.example.glviewshader6] ok
01-31 05:58:37.312+0900 D/PKGMGR  (13163): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
01-31 05:58:37.312+0900 D/PKGMGR  (13163): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
01-31 05:58:37.312+0900 D/PKGMGR  (13163): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] /opt/usr/apps/tmp/org.example.glviewshader6-1.0.1-i386.tpk_1784818984 / coretpk / org.example.glviewshader6 / end / ok
01-31 05:58:37.312+0900 D/PKGMGR  (13163): pkgmgr.c: __status_callback(440) > [SECURE_LOG] __status_callback() req_id[/opt/usr/apps/tmp/org.example.glviewshader6-1.0.1-i386.tpk_1784818984] pkg_type[coretpk] pkgid[org.example.glviewshader6]key[end] val[ok]
01-31 05:58:37.312+0900 D/W_HOME  (13163): clock_event.c: _pkgmgr_event_cb(123) > pkg:org.example.glviewshader6 key:end val:ok
01-31 05:58:37.312+0900 D/PKGMGR  (13163): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
01-31 05:58:37.312+0900 D/PKGMGR  (13163): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
01-31 05:58:37.312+0900 D/PKGMGR  (13163): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] /opt/usr/apps/tmp/org.example.glviewshader6-1.0.1-i386.tpk_1784818984 / coretpk / org.example.glviewshader6 / end / ok
01-31 05:58:37.312+0900 D/PKGMGR  (13163): pkgmgr.c: __status_callback(440) > [SECURE_LOG] __status_callback() req_id[/opt/usr/apps/tmp/org.example.glviewshader6-1.0.1-i386.tpk_1784818984] pkg_type[coretpk] pkgid[org.example.glviewshader6]key[end] val[ok]
01-31 05:58:37.312+0900 D/APPS    (13163): pkgmgr.c: _pkgmgr_cb(704) >  pkgmgr request [end:ok] for org.example.glviewshader6
01-31 05:58:37.312+0900 D/APPS    (13163): pkgmgr.c: _end(651) >  Package(org.example.glviewshader6) : key(update) - val(ok)
01-31 05:58:37.322+0900 D/PKGMGR  ( 2391): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] /opt/usr/apps/tmp/org.example.glviewshader6-1.0.1-i386.tpk_1784818984 / coretpk / org.example.glviewshader6 / end / ok
01-31 05:58:37.322+0900 D/PKGMGR  ( 2391): pkgmgr.c: __status_callback(440) > [SECURE_LOG] __status_callback() req_id[/opt/usr/apps/tmp/org.example.glviewshader6-1.0.1-i386.tpk_1784818984] pkg_type[coretpk] pkgid[org.example.glviewshader6]key[end] val[ok]
01-31 05:58:37.322+0900 D/PKGMGR  ( 2391): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
01-31 05:58:37.322+0900 D/PKGMGR  ( 2391): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
01-31 05:58:37.322+0900 D/PKGMGR  ( 2261): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] /opt/usr/apps/tmp/org.example.glviewshader6-1.0.1-i386.tpk_1784818984 / coretpk / org.example.glviewshader6 / end / ok
01-31 05:58:37.322+0900 D/PKGMGR  ( 2261): pkgmgr.c: __status_callback(440) > [SECURE_LOG] __status_callback() req_id[/opt/usr/apps/tmp/org.example.glviewshader6-1.0.1-i386.tpk_1784818984] pkg_type[coretpk] pkgid[org.example.glviewshader6]key[end] val[ok]
01-31 05:58:37.322+0900 D/DATA_PROVIDER_MASTER( 2261): pkgmgr.c: end_cb(409) > [SECURE_LOG] [org.example.glviewshader6] ok
01-31 05:58:37.322+0900 D/PKGMGR  ( 2261): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
01-31 05:58:37.322+0900 D/PKGMGR  ( 2261): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
01-31 05:58:37.322+0900 D/PKGMGR  ( 2262): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] /opt/usr/apps/tmp/org.example.glviewshader6-1.0.1-i386.tpk_1784818984 / coretpk / org.example.glviewshader6 / end / ok
01-31 05:58:37.322+0900 D/PKGMGR  ( 2262): pkgmgr.c: __status_callback(440) > [SECURE_LOG] __status_callback() req_id[/opt/usr/apps/tmp/org.example.glviewshader6-1.0.1-i386.tpk_1784818984] pkg_type[coretpk] pkgid[org.example.glviewshader6]key[end] val[ok]
01-31 05:58:37.322+0900 D/PKGMGR  ( 2262): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
01-31 05:58:37.322+0900 D/PKGMGR  ( 2262): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
01-31 05:58:37.322+0900 D/PKGMGR  ( 2221): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] /opt/usr/apps/tmp/org.example.glviewshader6-1.0.1-i386.tpk_1784818984 / coretpk / org.example.glviewshader6 / end / ok
01-31 05:58:37.322+0900 D/PKGMGR  ( 2221): pkgmgr.c: __status_callback(440) > [SECURE_LOG] __status_callback() req_id[/opt/usr/apps/tmp/org.example.glviewshader6-1.0.1-i386.tpk_1784818984] pkg_type[coretpk] pkgid[org.example.glviewshader6]key[end] val[ok]
01-31 05:58:37.322+0900 D/PKGMGR  ( 2221): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
01-31 05:58:37.322+0900 D/PKGMGR  ( 2221): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
01-31 05:58:37.322+0900 D/PKGMGR  ( 2157): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [install] /opt/usr/apps/tmp/org.example.glviewshader6-1.0.1-i386.tpk_1784818984 / coretpk / org.example.glviewshader6 / end / ok
01-31 05:58:37.322+0900 D/PKGMGR  ( 2157): pkgmgr.c: __status_callback(440) > [SECURE_LOG] __status_callback() req_id[/opt/usr/apps/tmp/org.example.glviewshader6-1.0.1-i386.tpk_1784818984] pkg_type[coretpk] pkgid[org.example.glviewshader6]key[end] val[ok]
01-31 05:58:37.322+0900 D/AUL_AMD ( 2157): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(538) > [SECURE_LOG] pkgid(org.example.glviewshader6), key(end), value(ok)
01-31 05:58:37.322+0900 D/AUL_AMD ( 2157): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(564) > [SECURE_LOG] op(install), value(ok)
01-31 05:58:37.322+0900 D/AUL_AMD ( 2157): amd_appinfo.c: __app_info_insert_handler(185) > __app_info_insert_handler
01-31 05:58:37.322+0900 D/AUL_AMD ( 2157): amd_appinfo.c: __app_info_insert_handler(388) > [SECURE_LOG] appinfo file:org.example.glviewshader6, comp:ui, type:rpm
01-31 05:58:37.322+0900 D/PKGMGR  ( 2157): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
01-31 05:58:37.322+0900 D/PKGMGR  ( 2157): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
01-31 05:58:37.322+0900 D/rpm-installer(32233): coretpk-installer.c: _coretpk_installer_prepare_package_install(2777) > success
01-31 05:58:37.322+0900 D/rpm-installer(32233): rpm-appcore-intf.c: main(224) > sync() start
01-31 05:58:37.332+0900 D/rpm-installer(32233): rpm-appcore-intf.c: main(226) > sync() end
01-31 05:58:37.332+0900 D/rpm-installer(32233): rpm-appcore-intf.c: main(245) > ------------------------------------------------
01-31 05:58:37.332+0900 D/rpm-installer(32233): rpm-appcore-intf.c: main(246) >  [END] rpm-installer: result=[0]
01-31 05:58:37.332+0900 D/rpm-installer(32233): rpm-appcore-intf.c: main(247) > ------------------------------------------------
01-31 05:58:37.332+0900 D/PKGMGR_SERVER(32232): pkgmgr-server.c: sighandler(326) > child exit [32233]
01-31 05:58:37.332+0900 D/PKGMGR_SERVER(32232): pkgmgr-server.c: sighandler(341) > child NORMAL exit [32233]
01-31 05:58:37.332+0900 D/APPS    (13163): pkgmgr.c: _end_cb(614) > [SECURE_LOG]  status[update], appid[org.example.glviewshader6]
01-31 05:58:37.332+0900 D/APPS    (13163): scroller.c: apps_scroller_get_item_by_appid(1427) > [SECURE_LOG]  Get [org.example.glviewshader6]'s item object
01-31 05:58:37.332+0900 D/APPS    (13163): db.c: apps_db_remove_item(404) >  Remove the item[org.example.glviewshader6]
01-31 05:58:37.342+0900 D/APPS    (13163): pkgmgr.c: _uninstall_app(536) > [SECURE_LOG]  appid[org.example.glviewshader6], name[glviewshader6]
01-31 05:58:37.342+0900 D/APPS    (13163): item_badge.c: item_badge_remove(305) > [SECURE_LOG]  pkgid: [org.example.glviewshader6]
01-31 05:58:37.342+0900 D/DATA_PROVIDER_MASTER( 2261): service_common.c: tcb_create(482) > [SECURE_LOG] Create a new service thread [48]
01-31 05:58:37.342+0900 D/DATA_PROVIDER_MASTER( 2261): badge_service.c: service_thread_main(499) > [SECURE_LOG] Command: [delete_badge], Packet type[0]
01-31 05:58:37.342+0900 E/DATA_PROVIDER_MASTER( 2261): badge_service.c: _is_manager_permission(86) > [SECURE_LOG] SMACK:not a manager
01-31 05:58:37.342+0900 D/BADGE   ( 2261): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.example.glviewshader6'], count[0]
01-31 05:58:37.342+0900 D/DATA_PROVIDER_MASTER( 2261): service_common.c: service_common_unicast_packet(1134) > [SECURE_LOG] Unicast packet
01-31 05:58:37.342+0900 E/DATA_PROVIDER_MASTER( 2261): badge_service.c: _handler_delete_badge(202) > [SECURE_LOG] Failed to delete a badge:-17956860
01-31 05:58:37.342+0900 D/COM_CORE(13163): com-core_packet.c: com_core_packet_oneshot_send(655) > [SECURE_LOG] Recv'd size: 60 (header: 60) pid: 2261, fd: -1
01-31 05:58:37.342+0900 D/COM_CORE(13163): com-core_packet.c: com_core_packet_oneshot_send(701) > [SECURE_LOG] Recv'd 4 bytes (pid: 2261), fd: -1
01-31 05:58:37.342+0900 D/COM_CORE(13163): com-core_packet.c: com_core_packet_oneshot_send(718) > [SECURE_LOG] Close connection: 49 (recv_fd: -1)
01-31 05:58:37.342+0900 D/APPS    (13163): item_badge.c: item_badge_remove(305) > [SECURE_LOG]  pkgid: [org.example.glviewshader6]
01-31 05:58:37.342+0900 D/DATA_PROVIDER_MASTER( 2261): service_common.c: tcb_create(482) > [SECURE_LOG] Create a new service thread [51]
01-31 05:58:37.342+0900 D/DATA_PROVIDER_MASTER( 2261): badge_service.c: service_thread_main(499) > [SECURE_LOG] Command: [delete_badge], Packet type[0]
01-31 05:58:37.342+0900 E/DATA_PROVIDER_MASTER( 2261): badge_service.c: _is_manager_permission(86) > [SECURE_LOG] SMACK:not a manager
01-31 05:58:37.342+0900 D/BADGE   ( 2261): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.example.glviewshader6'], count[0]
01-31 05:58:37.342+0900 D/DATA_PROVIDER_MASTER( 2261): service_common.c: service_common_unicast_packet(1134) > [SECURE_LOG] Unicast packet
01-31 05:58:37.342+0900 E/DATA_PROVIDER_MASTER( 2261): badge_service.c: _handler_delete_badge(202) > [SECURE_LOG] Failed to delete a badge:-17956860
01-31 05:58:37.342+0900 D/COM_CORE(13163): com-core_packet.c: com_core_packet_oneshot_send(655) > [SECURE_LOG] Recv'd size: 60 (header: 60) pid: 2261, fd: -1
01-31 05:58:37.342+0900 D/COM_CORE(13163): com-core_packet.c: com_core_packet_oneshot_send(701) > [SECURE_LOG] Recv'd 4 bytes (pid: 2261), fd: -1
01-31 05:58:37.342+0900 D/COM_CORE(13163): com-core_packet.c: com_core_packet_oneshot_send(718) > [SECURE_LOG] Close connection: 49 (recv_fd: -1)
01-31 05:58:37.342+0900 E/W_HOME  (13163): scroller.c: apps_scroller_trim(940) > (!item) -> continue
01-31 05:58:37.352+0900 D/DATA_PROVIDER_MASTER( 2261): service_common.c: client_packet_pump_main(353) > [SECURE_LOG] Packet received: 103 bytes
01-31 05:58:37.352+0900 D/DATA_PROVIDER_MASTER( 2261): service_common.c: client_packet_pump_main(353) > [SECURE_LOG] Packet received: 103 bytes
01-31 05:58:37.352+0900 D/COM_CORE( 2261): secure_socket.c: secure_socket_recv_with_fd(610) > [SECURE_LOG] Disconnected
01-31 05:58:37.352+0900 D/DATA_PROVIDER_MASTER( 2261): badge_service.c: service_thread_main(490) > [SECURE_LOG] TCB: 0xb8893c30 is terminated (NIL packet)
01-31 05:58:37.352+0900 D/DATA_PROVIDER_MASTER( 2261): service_common.c: tcb_destroy(613) > [SECURE_LOG] Thread returns: 0xffffff83
01-31 05:58:37.352+0900 D/COM_CORE( 2261): secure_socket.c: secure_socket_recv_with_fd(610) > [SECURE_LOG] Disconnected
01-31 05:58:37.352+0900 D/DATA_PROVIDER_MASTER( 2261): badge_service.c: service_thread_main(490) > [SECURE_LOG] TCB: 0xb88939a8 is terminated (NIL packet)
01-31 05:58:37.352+0900 D/DATA_PROVIDER_MASTER( 2261): service_common.c: tcb_destroy(613) > [SECURE_LOG] Thread returns: 0xffffff83
01-31 05:58:37.352+0900 D/APPS    (13163): pkgmgr.c: _install_app(496) > [SECURE_LOG]  appid[org.example.glviewshader6], name[glviewshader6]
01-31 05:58:37.352+0900 D/APPS    (13163): item.c: item_create(819) >  Icon size after ea_effect (124:127)
01-31 05:58:37.352+0900 D/BADGE   (13163): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.example.glviewshader6'], count[0]
01-31 05:58:37.352+0900 D/APPS    (13163): scroller.c: apps_scroller_write_list(1344) > [SECURE_LOG]  [org.tizen.clocksetting]'s ordering : 0
01-31 05:58:37.352+0900 D/APPS    (13163): scroller.c: apps_scroller_write_list(1344) > [SECURE_LOG]  [org.example.glviewshader6]'s ordering : 1
01-31 05:58:37.352+0900 D/APPS    (13163): db.c: apps_db_update_item(374) >  Update the item[org.tizen.clocksetting:0]
01-31 05:58:37.362+0900 D/APPS    (13163): db.c: apps_db_insert_item(345) >  Insert the item[org.example.glviewshader6:1]
01-31 05:58:37.362+0900 D/PKGMGR  (13163): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
01-31 05:58:37.362+0900 D/PKGMGR  (13163): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
01-31 05:58:38.992+0900 D/PKGMGR_SERVER(32232): pkgmgr-server.c: exit_server(724) > exit_server Start
01-31 05:58:38.992+0900 D/PKGMGR_SERVER(32232): pkgmgr-server.c: main(1516) > Quit main loop.
01-31 05:58:38.992+0900 D/PKGMGR_SERVER(32232): pkgmgr-server.c: main(1524) > package manager server terminated.
01-31 05:58:42.152+0900 D/AUL_AMD ( 2157): amd_request.c: __request_handler(495) > __request_handler: 0
01-31 05:58:42.152+0900 D/AUL_AMD ( 2157): amd_request.c: __request_handler(540) > launch a single-instance appid: org.example.glviewshader6
01-31 05:58:42.152+0900 D/AUL     ( 2157): pkginfo.c: aul_app_get_appid_bypid(205) > second change pgid = 32290, pid = 32292
01-31 05:58:42.152+0900 D/AUL_AMD ( 2157): amd_launch.c: _start_app(1479) > [SECURE_LOG] caller : (null)
01-31 05:58:42.152+0900 D/AUL_AMD ( 2157): amd_launch.c: _start_app(1785) > process_pool: false
01-31 05:58:42.152+0900 D/AUL_AMD ( 2157): amd_launch.c: _start_app(1788) > h/w acceleration: USE
01-31 05:58:42.152+0900 D/AUL_AMD ( 2157): amd_launch.c: _start_app(1790) > [SECURE_LOG] appid: org.example.glviewshader6
01-31 05:58:42.152+0900 D/AUL_AMD ( 2157): amd_launch.c: __set_appinfo_for_launchpad(1950) > Add hwacc, taskmanage, app_path and pkg_type into bundle for sending those to launchpad.
01-31 05:58:42.152+0900 D/AUL     ( 2157): app_sock.c: __app_send_raw(265) > pid(-1) : cmd(0)
01-31 05:58:42.152+0900 D/AUL_PAD ( 2183): launchpad.c: __launchpad_main_loop(641) > [SECURE_LOG] pkg name : org.example.glviewshader6
01-31 05:58:42.152+0900 D/AUL_PAD ( 2183): launchpad.c: __modify_bundle(380) > parsing app_path: No arguments
01-31 05:58:42.152+0900 D/AUL_PAD ( 2183): launchpad.c: __launchpad_main_loop(699) > [SECURE_LOG] ==> real launch pid : 32293 /opt/usr/apps/org.example.glviewshader6/bin/glviewshader6
01-31 05:58:42.152+0900 D/AUL_PAD ( 2183): launchpad.c: __send_result_to_caller(555) > -- now wait to change cmdline --
01-31 05:58:42.152+0900 D/AUL_PAD (32293): launchpad.c: __launchpad_main_loop(668) > lock up test log(no error) : fork done
01-31 05:58:42.152+0900 D/AUL_PAD (32293): launchpad.c: __launchpad_main_loop(679) > lock up test log(no error) : prepare exec - first done
01-31 05:58:42.152+0900 D/AUL_PAD (32293): launchpad.c: __prepare_exec(136) > [SECURE_LOG] pkg_name : org.example.glviewshader6 / pkg_type : rpm / app_path : /opt/usr/apps/org.example.glviewshader6/bin/glviewshader6 
01-31 05:58:42.152+0900 D/AUL_PAD (32293): launchpad.c: __launchpad_main_loop(693) > lock up test log(no error) : prepare exec - second done
01-31 05:58:42.152+0900 D/AUL_PAD (32293): launchpad.c: __real_launch(223) > [SECURE_LOG] input argument 0 : /opt/usr/apps/org.example.glviewshader6/bin/glviewshader6##
01-31 05:58:42.152+0900 D/AUL_PAD (32293): launchpad.c: __real_launch(223) > [SECURE_LOG] input argument 2 : __AUL_STARTTIME__##
01-31 05:58:42.152+0900 D/AUL_PAD (32293): launchpad.c: __real_launch(223) > [SECURE_LOG] input argument 4 : __AUL_CALLER_PID__##
01-31 05:58:42.152+0900 D/LAUNCH  (32293): launchpad.c: __real_launch(229) > [SECURE_LOG] [/opt/usr/apps/org.example.glviewshader6/bin/glviewshader6:Platform:launchpad:done]
01-31 05:58:42.152+0900 I/efl-extension(32293): efl_extension.c: eext_mod_init(39) > Init
01-31 05:58:42.152+0900 I/CAPI_APPFW_APPLICATION(32293): app_main.c: ui_app_main(701) > app_efl_main
01-31 05:58:42.152+0900 D/LAUNCH  (32293): appcore-efl.c: appcore_efl_main(1571) > [glviewshader6:Application:main:done]
01-31 05:58:42.172+0900 D/APP_CORE(32293): appcore-efl.c: __before_loop(1012) > elm_config_preferred_engine_set : opengl_x11
01-31 05:58:42.172+0900 D/AUL     (32293): pkginfo.c: aul_app_get_pkgid_bypid(257) > [SECURE_LOG] appid for 32293 is org.example.glviewshader6
01-31 05:58:42.172+0900 D/APP_CORE(32293): appcore.c: appcore_init(532) > [SECURE_LOG] dir : /usr/apps/org.example.glviewshader6/res/locale
01-31 05:58:42.172+0900 D/APP_CORE(32293): appcore-i18n.c: update_region(71) > *****appcore setlocale=en_GB.UTF-8
01-31 05:58:42.172+0900 D/AUL     (32293): app_sock.c: __create_server_sock(136) > pg path - already exists
01-31 05:58:42.172+0900 D/LAUNCH  (32293): appcore-efl.c: __before_loop(1035) > [glviewshader6:Platform:appcore_init:done]
01-31 05:58:42.172+0900 I/CAPI_APPFW_APPLICATION(32293): app_main.c: _ui_app_appcore_create(559) > app_appcore_create
01-31 05:58:42.252+0900 D/AUL_PAD ( 2183): sigchild.h: __signal_block_sigchld(230) > SIGCHLD blocked
01-31 05:58:42.252+0900 D/AUL_PAD ( 2183): sigchild.h: __send_app_launch_signal(112) > send launch signal done
01-31 05:58:42.252+0900 D/AUL_PAD ( 2183): sigchild.h: __signal_unblock_sigchld(242) > SIGCHLD unblocked
01-31 05:58:42.252+0900 D/AUL     ( 2157): simple_util.c: __trm_app_info_send_socket(261) > __trm_app_info_send_socket
01-31 05:58:42.252+0900 E/AUL     ( 2157): simple_util.c: __trm_app_info_send_socket(264) > access
01-31 05:58:42.252+0900 D/RESOURCED( 2363): proc-noti.c: recv_str(87) > [recv_str,87] str is null
01-31 05:58:42.252+0900 D/RESOURCED( 2363): proc-noti.c: process_message(169) > [process_message,169] process message caller pid 2157
01-31 05:58:42.252+0900 D/RESOURCED( 2363): proc-main.c: resourced_proc_action(669) > [SECURE_LOG] [resourced_proc_action,669] appid org.example.glviewshader6, pid 32293, type 4 
01-31 05:58:42.252+0900 D/RESOURCED( 2363): proc-main.c: resourced_proc_status_change(570) > [SECURE_LOG] [resourced_proc_status_change,570] launch request org.example.glviewshader6, 32293
01-31 05:58:42.252+0900 D/RESOURCED( 2363): proc-main.c: resourced_proc_status_change(572) > [SECURE_LOG] [resourced_proc_status_change,572] launch request org.example.glviewshader6 with pkgname
01-31 05:58:42.252+0900 E/RESOURCED( 2363): proc-main.c: resourced_proc_status_change(577) > [resourced_proc_status_change,577] available memory = 341
01-31 05:58:42.252+0900 D/RESOURCED( 2363): proc-noti.c: safe_write_int(178) > [safe_write_int,178] Response is not needed
01-31 05:58:42.402+0900 E/EFL     (32293): eina_module<32293> eina_module.c:339 eina_module_load() could not dlopen("/opt/home/app/.edje/modules/elm/linux-gnu-i686-1.0.0/module.so", RTLD_NOW): /opt/home/app/.edje/modules/elm/linux-gnu-i686-1.0.0/module.so: cannot open shared object file: No such file or directory
01-31 05:58:42.402+0900 E/EFL     (32293): ecore_evas<32293> ecore_evas_extn.c:2169 ecore_evas_extn_plug_connect() Extn plug failed to connect:ipctype=0, svcname=elm_indicator_portrait, svcnum=0, svcsys=0
01-31 05:58:42.412+0900 D/W_HOME  (13163): main.c: _window_focus_out_cb(869) > focus out
01-31 05:58:42.412+0900 D/W_HOME  (13163): main.c: _pause_cb(600) > Paused
01-31 05:58:42.412+0900 D/W_HOME  (13163): page.c: page_focus(701) > focus set to 0xb8721290
01-31 05:58:42.412+0900 W/W_HOME  (13163): main.c: _pause_cb(613) > clock/widget paused
01-31 05:58:42.412+0900 D/W_HOME  (13163): clock_view.c: clock_view_event_handler(843) > event:10002 received
01-31 05:58:42.412+0900 E/APPS    (13163): apps_main.c: _window_focus_out_cb(313) >  win[20971527], ev->win[20971523]
01-31 05:58:42.422+0900 D/DATA_PROVIDER_MASTER( 2261): xmonitor.c: xmonitor_pause(331) > [SECURE_LOG] 13163 is paused
01-31 05:58:42.422+0900 D/DATA_PROVIDER_MASTER( 2261): client_life.c: client_is_all_paused(479) > [SECURE_LOG] 1, 1
01-31 05:58:42.422+0900 D/LAUNCH  (32293): appcore-efl.c: __before_loop(1047) > [glviewshader6:Application:create:done]
01-31 05:58:42.422+0900 D/APP_CORE(32293): appcore-efl.c: __check_wm_rotation_support(752) > Disable window manager rotation
01-31 05:58:42.422+0900 D/APP_CORE(32293): appcore.c: __aul_handler(423) > [APP 32293]     AUL event: AUL_START
01-31 05:58:42.422+0900 D/APP_CORE(32293): appcore-efl.c: __do_app(470) > [APP 32293] Event: RESET State: CREATED
01-31 05:58:42.422+0900 D/APP_CORE(32293): appcore-efl.c: __do_app(496) > [APP 32293] RESET
01-31 05:58:42.422+0900 D/LAUNCH  (32293): appcore-efl.c: __do_app(498) > [glviewshader6:Application:reset:start]
01-31 05:58:42.422+0900 I/CAPI_APPFW_APPLICATION(32293): app_main.c: _ui_app_appcore_reset(642) > app_appcore_reset
01-31 05:58:42.422+0900 D/APP_SVC (32293): appsvc.c: __set_bundle(161) > __set_bundle
01-31 05:58:42.422+0900 D/LAUNCH  (32293): appcore-efl.c: __do_app(501) > [glviewshader6:Application:reset:done]
01-31 05:58:42.422+0900 I/APP_CORE(32293): appcore-efl.c: __do_app(507) > Legacy lifecycle: 0
01-31 05:58:42.422+0900 I/APP_CORE(32293): appcore-efl.c: __do_app(509) > [APP 32293] Initial Launching, call the resume_cb
01-31 05:58:42.422+0900 I/CAPI_APPFW_APPLICATION(32293): app_main.c: _ui_app_appcore_resume(624) > app_appcore_resume
01-31 05:58:42.422+0900 D/APP_CORE(32293): appcore.c: __aul_handler(426) > [SECURE_LOG] caller_appid : (null)
01-31 05:58:42.422+0900 D/APP_CORE(32293): appcore-efl.c: __show_cb(826) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:1c00003
01-31 05:58:42.422+0900 D/APP_CORE(32293): appcore-efl.c: __add_win(672) > [EVENT_TEST][EVENT] __add_win WIN:1c00003
01-31 05:58:42.462+0900 W/CRASH_MANAGER(32294): worker.c: worker_job(1189) > 1132293676c76145418752
