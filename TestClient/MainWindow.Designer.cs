﻿/*
    TestClient for obs-websocket-dotnet
    Copyright (C) 2017	Stéphane Lepin <stephane.lepin@gmail.com>

    This program is free software; you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation; either version 2 of the License, or
    (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License along
    with this program. If not, see <https://www.gnu.org/licenses/>
*/

namespace TestClient
{
    partial class MainWindow
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtServerIP = new System.Windows.Forms.TextBox();
            this.txtServerPassword = new System.Windows.Forms.TextBox();
            this.tvScenes = new System.Windows.Forms.TreeView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSetCurrentScene = new System.Windows.Forms.Button();
            this.btnGetCurrentScene = new System.Windows.Forms.Button();
            this.btnListScenes = new System.Windows.Forms.Button();
            this.tbCurrentScene = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbControls = new System.Windows.Forms.GroupBox();
            this.gbCustomRTMP = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnStartCommonStreaming = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.comboCommonServer = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.tbCommonKey = new System.Windows.Forms.TextBox();
            this.comboCommonService = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnStartCustomStreaming = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tbCustomStreamName = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.cbUseAuth = new System.Windows.Forms.CheckBox();
            this.tbCustomServer = new System.Windows.Forms.TextBox();
            this.tbCustomAuthUsername = new System.Windows.Forms.TextBox();
            this.tbCustomAuthPassword = new System.Windows.Forms.TextBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.btnSetTransitionDuration = new System.Windows.Forms.Button();
            this.btnGetTransitionDuration = new System.Windows.Forms.Button();
            this.tbTransitionDuration = new System.Windows.Forms.NumericUpDown();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnSetCurrentTransition = new System.Windows.Forms.Button();
            this.btnGetCurrentTransition = new System.Windows.Forms.Button();
            this.tbTransition = new System.Windows.Forms.TextBox();
            this.btnListTransitions = new System.Windows.Forms.Button();
            this.tvTransitions = new System.Windows.Forms.TreeView();
            this.gbStatus = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.txtTotalFrames = new System.Windows.Forms.Label();
            this.txtDroppedFrames = new System.Windows.Forms.Label();
            this.txtStrain = new System.Windows.Forms.Label();
            this.txtFramerate = new System.Windows.Forms.Label();
            this.txtBytesSec = new System.Windows.Forms.Label();
            this.txtKbitsSec = new System.Windows.Forms.Label();
            this.txtStreamTime = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnToggleRecording = new System.Windows.Forms.Button();
            this.btnToggleStreaming = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnSetCurrentProfile = new System.Windows.Forms.Button();
            this.btnGetCurrentProfile = new System.Windows.Forms.Button();
            this.tbProfile = new System.Windows.Forms.TextBox();
            this.btnListProfiles = new System.Windows.Forms.Button();
            this.tvProfiles = new System.Windows.Forms.TreeView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSetCurrentSceneCol = new System.Windows.Forms.Button();
            this.btnGetCurrentSceneCol = new System.Windows.Forms.Button();
            this.tbSceneCol = new System.Windows.Forms.TextBox();
            this.btnListSceneCol = new System.Windows.Forms.Button();
            this.tvSceneCols = new System.Windows.Forms.TreeView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tbOBSVersion = new System.Windows.Forms.Label();
            this.tbAPIVersion = new System.Windows.Forms.Label();
            this.tbPluginVersion = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.gbControls.SuspendLayout();
            this.gbCustomRTMP.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbTransitionDuration)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.gbStatus.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConnect.Location = new System.Drawing.Point(772, 5);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 1;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtServerIP
            // 
            this.txtServerIP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtServerIP.Location = new System.Drawing.Point(464, 7);
            this.txtServerIP.Name = "txtServerIP";
            this.txtServerIP.Size = new System.Drawing.Size(114, 20);
            this.txtServerIP.TabIndex = 2;
            this.txtServerIP.Text = "ws://127.0.0.1:4444";
            // 
            // txtServerPassword
            // 
            this.txtServerPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtServerPassword.Location = new System.Drawing.Point(652, 7);
            this.txtServerPassword.Name = "txtServerPassword";
            this.txtServerPassword.Size = new System.Drawing.Size(114, 20);
            this.txtServerPassword.TabIndex = 3;
            this.txtServerPassword.UseSystemPasswordChar = true;
            // 
            // tvScenes
            // 
            this.tvScenes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tvScenes.Location = new System.Drawing.Point(6, 49);
            this.tvScenes.Name = "tvScenes";
            this.tvScenes.Size = new System.Drawing.Size(152, 118);
            this.tvScenes.TabIndex = 4;
            this.tvScenes.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvScenes_NodeMouseClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSetCurrentScene);
            this.groupBox1.Controls.Add(this.btnGetCurrentScene);
            this.groupBox1.Controls.Add(this.btnListScenes);
            this.groupBox1.Controls.Add(this.tvScenes);
            this.groupBox1.Controls.Add(this.tbCurrentScene);
            this.groupBox1.Location = new System.Drawing.Point(6, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(164, 243);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Scene List with Items";
            // 
            // btnSetCurrentScene
            // 
            this.btnSetCurrentScene.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSetCurrentScene.Location = new System.Drawing.Point(92, 199);
            this.btnSetCurrentScene.Name = "btnSetCurrentScene";
            this.btnSetCurrentScene.Size = new System.Drawing.Size(66, 38);
            this.btnSetCurrentScene.TabIndex = 1;
            this.btnSetCurrentScene.Text = "Set\r\nCurScene";
            this.btnSetCurrentScene.UseVisualStyleBackColor = true;
            this.btnSetCurrentScene.Click += new System.EventHandler(this.btnSetCurrentScene_Click);
            // 
            // btnGetCurrentScene
            // 
            this.btnGetCurrentScene.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGetCurrentScene.Location = new System.Drawing.Point(6, 199);
            this.btnGetCurrentScene.Name = "btnGetCurrentScene";
            this.btnGetCurrentScene.Size = new System.Drawing.Size(62, 38);
            this.btnGetCurrentScene.TabIndex = 2;
            this.btnGetCurrentScene.Text = "Get\r\nCurScene";
            this.btnGetCurrentScene.UseVisualStyleBackColor = true;
            this.btnGetCurrentScene.Click += new System.EventHandler(this.btnGetCurrentScene_Click);
            // 
            // btnListScenes
            // 
            this.btnListScenes.Location = new System.Drawing.Point(7, 20);
            this.btnListScenes.Name = "btnListScenes";
            this.btnListScenes.Size = new System.Drawing.Size(75, 23);
            this.btnListScenes.TabIndex = 5;
            this.btnListScenes.Text = "ListScenes";
            this.btnListScenes.UseVisualStyleBackColor = true;
            this.btnListScenes.Click += new System.EventHandler(this.btnListScenes_Click);
            // 
            // tbCurrentScene
            // 
            this.tbCurrentScene.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCurrentScene.Location = new System.Drawing.Point(6, 173);
            this.tbCurrentScene.Name = "tbCurrentScene";
            this.tbCurrentScene.Size = new System.Drawing.Size(152, 20);
            this.tbCurrentScene.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(405, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "IP:PORT :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(591, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Password :";
            // 
            // gbControls
            // 
            this.gbControls.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbControls.Controls.Add(this.button1);
            this.gbControls.Controls.Add(this.gbCustomRTMP);
            this.gbControls.Controls.Add(this.groupBox7);
            this.gbControls.Controls.Add(this.groupBox6);
            this.gbControls.Controls.Add(this.gbStatus);
            this.gbControls.Controls.Add(this.groupBox5);
            this.gbControls.Controls.Add(this.groupBox4);
            this.gbControls.Controls.Add(this.groupBox2);
            this.gbControls.Controls.Add(this.groupBox3);
            this.gbControls.Controls.Add(this.groupBox1);
            this.gbControls.Enabled = false;
            this.gbControls.Location = new System.Drawing.Point(12, 34);
            this.gbControls.Name = "gbControls";
            this.gbControls.Size = new System.Drawing.Size(835, 515);
            this.gbControls.TabIndex = 9;
            this.gbControls.TabStop = false;
            // 
            // gbCustomRTMP
            // 
            this.gbCustomRTMP.Controls.Add(this.tabControl1);
            this.gbCustomRTMP.Location = new System.Drawing.Point(377, 261);
            this.gbCustomRTMP.Name = "gbCustomRTMP";
            this.gbCustomRTMP.Size = new System.Drawing.Size(261, 243);
            this.gbCustomRTMP.TabIndex = 13;
            this.gbCustomRTMP.TabStop = false;
            this.gbCustomRTMP.Text = "Custom RTMP settings";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(11, 19);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(244, 218);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnStartCommonStreaming);
            this.tabPage1.Controls.Add(this.tableLayoutPanel3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(236, 192);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Common";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnStartCommonStreaming
            // 
            this.btnStartCommonStreaming.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStartCommonStreaming.Location = new System.Drawing.Point(128, 163);
            this.btnStartCommonStreaming.Name = "btnStartCommonStreaming";
            this.btnStartCommonStreaming.Size = new System.Drawing.Size(102, 23);
            this.btnStartCommonStreaming.TabIndex = 3;
            this.btnStartCommonStreaming.Text = "Start streaming";
            this.btnStartCommonStreaming.UseVisualStyleBackColor = true;
            this.btnStartCommonStreaming.Click += new System.EventHandler(this.btnStartCommonStreaming_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.comboCommonServer, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.label13, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label14, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label15, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.tbCommonKey, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.comboCommonService, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(6, 8);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.Size = new System.Drawing.Size(224, 149);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // comboCommonServer
            // 
            this.comboCommonServer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboCommonServer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCommonServer.FormattingEnabled = true;
            this.comboCommonServer.Location = new System.Drawing.Point(60, 30);
            this.comboCommonServer.Name = "comboCommonServer";
            this.comboCommonServer.Size = new System.Drawing.Size(161, 21);
            this.comboCommonServer.TabIndex = 6;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 7);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "Service :";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(3, 34);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(51, 13);
            this.label14.TabIndex = 1;
            this.label14.Text = "Server :";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(3, 61);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(51, 13);
            this.label15.TabIndex = 3;
            this.label15.Text = "Key :";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbCommonKey
            // 
            this.tbCommonKey.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCommonKey.Location = new System.Drawing.Point(60, 57);
            this.tbCommonKey.Name = "tbCommonKey";
            this.tbCommonKey.Size = new System.Drawing.Size(161, 20);
            this.tbCommonKey.TabIndex = 4;
            this.tbCommonKey.UseSystemPasswordChar = true;
            // 
            // comboCommonService
            // 
            this.comboCommonService.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboCommonService.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCommonService.FormattingEnabled = true;
            this.comboCommonService.Location = new System.Drawing.Point(60, 3);
            this.comboCommonService.Name = "comboCommonService";
            this.comboCommonService.Size = new System.Drawing.Size(161, 21);
            this.comboCommonService.TabIndex = 5;
            this.comboCommonService.SelectedIndexChanged += new System.EventHandler(this.comboCommonService_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnStartCustomStreaming);
            this.tabPage2.Controls.Add(this.tableLayoutPanel4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(236, 192);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Custom";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnStartCustomStreaming
            // 
            this.btnStartCustomStreaming.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStartCustomStreaming.Location = new System.Drawing.Point(125, 163);
            this.btnStartCustomStreaming.Name = "btnStartCustomStreaming";
            this.btnStartCustomStreaming.Size = new System.Drawing.Size(105, 23);
            this.btnStartCustomStreaming.TabIndex = 4;
            this.btnStartCustomStreaming.Text = "Start streaming";
            this.btnStartCustomStreaming.UseVisualStyleBackColor = true;
            this.btnStartCustomStreaming.Click += new System.EventHandler(this.btnStartCustomStreaming_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 82F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.tbCustomStreamName, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.label16, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.label17, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.label19, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.label20, 0, 4);
            this.tableLayoutPanel4.Controls.Add(this.cbUseAuth, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.tbCustomServer, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.tbCustomAuthUsername, 1, 3);
            this.tableLayoutPanel4.Controls.Add(this.tbCustomAuthPassword, 1, 4);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(6, 6);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 6;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.Size = new System.Drawing.Size(224, 151);
            this.tableLayoutPanel4.TabIndex = 3;
            // 
            // tbCustomStreamName
            // 
            this.tbCustomStreamName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCustomStreamName.Location = new System.Drawing.Point(85, 30);
            this.tbCustomStreamName.Name = "tbCustomStreamName";
            this.tbCustomStreamName.Size = new System.Drawing.Size(136, 20);
            this.tbCustomStreamName.TabIndex = 9;
            this.tbCustomStreamName.UseSystemPasswordChar = true;
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(3, 7);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(76, 13);
            this.label16.TabIndex = 2;
            this.label16.Text = "Server :";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(3, 34);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(76, 13);
            this.label17.TabIndex = 3;
            this.label17.Text = "Stream name :";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label19
            // 
            this.label19.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(3, 88);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(76, 13);
            this.label19.TabIndex = 5;
            this.label19.Text = "Username :";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label20
            // 
            this.label20.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(3, 115);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(76, 13);
            this.label20.TabIndex = 6;
            this.label20.Text = "Password :";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbUseAuth
            // 
            this.cbUseAuth.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbUseAuth.AutoSize = true;
            this.cbUseAuth.Location = new System.Drawing.Point(85, 57);
            this.cbUseAuth.Name = "cbUseAuth";
            this.cbUseAuth.Size = new System.Drawing.Size(136, 21);
            this.cbUseAuth.TabIndex = 7;
            this.cbUseAuth.Text = "Use Authentication";
            this.cbUseAuth.UseVisualStyleBackColor = true;
            // 
            // tbCustomServer
            // 
            this.tbCustomServer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCustomServer.Location = new System.Drawing.Point(85, 3);
            this.tbCustomServer.Name = "tbCustomServer";
            this.tbCustomServer.Size = new System.Drawing.Size(136, 20);
            this.tbCustomServer.TabIndex = 8;
            // 
            // tbCustomAuthUsername
            // 
            this.tbCustomAuthUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCustomAuthUsername.Location = new System.Drawing.Point(85, 84);
            this.tbCustomAuthUsername.Name = "tbCustomAuthUsername";
            this.tbCustomAuthUsername.Size = new System.Drawing.Size(136, 20);
            this.tbCustomAuthUsername.TabIndex = 10;
            // 
            // tbCustomAuthPassword
            // 
            this.tbCustomAuthPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCustomAuthPassword.Location = new System.Drawing.Point(85, 111);
            this.tbCustomAuthPassword.Name = "tbCustomAuthPassword";
            this.tbCustomAuthPassword.Size = new System.Drawing.Size(136, 20);
            this.tbCustomAuthPassword.TabIndex = 11;
            this.tbCustomAuthPassword.UseSystemPasswordChar = true;
            // 
            // groupBox7
            // 
            this.groupBox7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox7.Controls.Add(this.btnSetTransitionDuration);
            this.groupBox7.Controls.Add(this.btnGetTransitionDuration);
            this.groupBox7.Controls.Add(this.tbTransitionDuration);
            this.groupBox7.Location = new System.Drawing.Point(691, 375);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(138, 79);
            this.groupBox7.TabIndex = 12;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Transition Duration";
            // 
            // btnSetTransitionDuration
            // 
            this.btnSetTransitionDuration.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSetTransitionDuration.Location = new System.Drawing.Point(89, 46);
            this.btnSetTransitionDuration.Name = "btnSetTransitionDuration";
            this.btnSetTransitionDuration.Size = new System.Drawing.Size(40, 23);
            this.btnSetTransitionDuration.TabIndex = 2;
            this.btnSetTransitionDuration.Text = "Set";
            this.btnSetTransitionDuration.UseVisualStyleBackColor = true;
            this.btnSetTransitionDuration.Click += new System.EventHandler(this.btnSetTransitionDuration_Click);
            // 
            // btnGetTransitionDuration
            // 
            this.btnGetTransitionDuration.Location = new System.Drawing.Point(7, 46);
            this.btnGetTransitionDuration.Name = "btnGetTransitionDuration";
            this.btnGetTransitionDuration.Size = new System.Drawing.Size(41, 23);
            this.btnGetTransitionDuration.TabIndex = 1;
            this.btnGetTransitionDuration.Text = "Get";
            this.btnGetTransitionDuration.UseVisualStyleBackColor = true;
            this.btnGetTransitionDuration.Click += new System.EventHandler(this.btnGetTransitionDuration_Click);
            // 
            // tbTransitionDuration
            // 
            this.tbTransitionDuration.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTransitionDuration.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.tbTransitionDuration.Location = new System.Drawing.Point(7, 20);
            this.tbTransitionDuration.Maximum = new decimal(new int[] {
            120000,
            0,
            0,
            0});
            this.tbTransitionDuration.Name = "tbTransitionDuration";
            this.tbTransitionDuration.Size = new System.Drawing.Size(122, 20);
            this.tbTransitionDuration.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnSetCurrentTransition);
            this.groupBox6.Controls.Add(this.btnGetCurrentTransition);
            this.groupBox6.Controls.Add(this.tbTransition);
            this.groupBox6.Controls.Add(this.btnListTransitions);
            this.groupBox6.Controls.Add(this.tvTransitions);
            this.groupBox6.Location = new System.Drawing.Point(176, 261);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(192, 243);
            this.groupBox6.TabIndex = 10;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Transitions";
            // 
            // btnSetCurrentTransition
            // 
            this.btnSetCurrentTransition.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSetCurrentTransition.Location = new System.Drawing.Point(104, 199);
            this.btnSetCurrentTransition.Name = "btnSetCurrentTransition";
            this.btnSetCurrentTransition.Size = new System.Drawing.Size(81, 38);
            this.btnSetCurrentTransition.TabIndex = 5;
            this.btnSetCurrentTransition.Text = "Set\r\nCurTransition";
            this.btnSetCurrentTransition.UseVisualStyleBackColor = true;
            this.btnSetCurrentTransition.Click += new System.EventHandler(this.btnSetCurrentTransition_Click);
            // 
            // btnGetCurrentTransition
            // 
            this.btnGetCurrentTransition.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGetCurrentTransition.Location = new System.Drawing.Point(6, 199);
            this.btnGetCurrentTransition.Name = "btnGetCurrentTransition";
            this.btnGetCurrentTransition.Size = new System.Drawing.Size(86, 38);
            this.btnGetCurrentTransition.TabIndex = 4;
            this.btnGetCurrentTransition.Text = "Get\r\nCurTransition";
            this.btnGetCurrentTransition.UseVisualStyleBackColor = true;
            this.btnGetCurrentTransition.Click += new System.EventHandler(this.btnGetCurrentTransition_Click);
            // 
            // tbTransition
            // 
            this.tbTransition.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTransition.Location = new System.Drawing.Point(6, 173);
            this.tbTransition.Name = "tbTransition";
            this.tbTransition.Size = new System.Drawing.Size(179, 20);
            this.tbTransition.TabIndex = 3;
            // 
            // btnListTransitions
            // 
            this.btnListTransitions.Location = new System.Drawing.Point(6, 19);
            this.btnListTransitions.Name = "btnListTransitions";
            this.btnListTransitions.Size = new System.Drawing.Size(86, 23);
            this.btnListTransitions.TabIndex = 2;
            this.btnListTransitions.Text = "ListTransitions";
            this.btnListTransitions.UseVisualStyleBackColor = true;
            this.btnListTransitions.Click += new System.EventHandler(this.btnListTransitions_Click);
            // 
            // tvTransitions
            // 
            this.tvTransitions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tvTransitions.Location = new System.Drawing.Point(6, 49);
            this.tvTransitions.Name = "tvTransitions";
            this.tvTransitions.Size = new System.Drawing.Size(180, 118);
            this.tvTransitions.TabIndex = 1;
            this.tvTransitions.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvTransitions_NodeMouseClick);
            // 
            // gbStatus
            // 
            this.gbStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbStatus.Controls.Add(this.tableLayoutPanel2);
            this.gbStatus.Enabled = false;
            this.gbStatus.Location = new System.Drawing.Point(600, 12);
            this.gbStatus.Name = "gbStatus";
            this.gbStatus.Size = new System.Drawing.Size(229, 175);
            this.gbStatus.TabIndex = 11;
            this.gbStatus.TabStop = false;
            this.gbStatus.Text = "Stream Status";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.txtTotalFrames, 1, 6);
            this.tableLayoutPanel2.Controls.Add(this.txtDroppedFrames, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.txtStrain, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.txtFramerate, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.txtBytesSec, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.txtKbitsSec, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtStreamTime, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label7, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label8, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label9, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label10, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.label11, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.label12, 0, 6);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(10, 20);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 8;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(213, 149);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // txtTotalFrames
            // 
            this.txtTotalFrames.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotalFrames.AutoSize = true;
            this.txtTotalFrames.Location = new System.Drawing.Point(103, 123);
            this.txtTotalFrames.Name = "txtTotalFrames";
            this.txtTotalFrames.Size = new System.Drawing.Size(107, 13);
            this.txtTotalFrames.TabIndex = 14;
            this.txtTotalFrames.Text = "0";
            this.txtTotalFrames.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDroppedFrames
            // 
            this.txtDroppedFrames.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDroppedFrames.AutoSize = true;
            this.txtDroppedFrames.Location = new System.Drawing.Point(103, 103);
            this.txtDroppedFrames.Name = "txtDroppedFrames";
            this.txtDroppedFrames.Size = new System.Drawing.Size(107, 13);
            this.txtDroppedFrames.TabIndex = 13;
            this.txtDroppedFrames.Text = "0";
            this.txtDroppedFrames.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtStrain
            // 
            this.txtStrain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStrain.AutoSize = true;
            this.txtStrain.Location = new System.Drawing.Point(103, 83);
            this.txtStrain.Name = "txtStrain";
            this.txtStrain.Size = new System.Drawing.Size(107, 13);
            this.txtStrain.TabIndex = 12;
            this.txtStrain.Text = "0 %";
            this.txtStrain.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtFramerate
            // 
            this.txtFramerate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFramerate.AutoSize = true;
            this.txtFramerate.Location = new System.Drawing.Point(103, 63);
            this.txtFramerate.Name = "txtFramerate";
            this.txtFramerate.Size = new System.Drawing.Size(107, 13);
            this.txtFramerate.TabIndex = 11;
            this.txtFramerate.Text = "0 fps";
            this.txtFramerate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtBytesSec
            // 
            this.txtBytesSec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBytesSec.AutoSize = true;
            this.txtBytesSec.Location = new System.Drawing.Point(103, 43);
            this.txtBytesSec.Name = "txtBytesSec";
            this.txtBytesSec.Size = new System.Drawing.Size(107, 13);
            this.txtBytesSec.TabIndex = 10;
            this.txtBytesSec.Text = "0 bytes/s";
            this.txtBytesSec.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtKbitsSec
            // 
            this.txtKbitsSec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtKbitsSec.AutoSize = true;
            this.txtKbitsSec.Location = new System.Drawing.Point(103, 23);
            this.txtKbitsSec.Name = "txtKbitsSec";
            this.txtKbitsSec.Size = new System.Drawing.Size(107, 13);
            this.txtKbitsSec.TabIndex = 9;
            this.txtKbitsSec.Text = "0 kbits/s";
            this.txtKbitsSec.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtStreamTime
            // 
            this.txtStreamTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStreamTime.AutoSize = true;
            this.txtStreamTime.Location = new System.Drawing.Point(103, 3);
            this.txtStreamTime.Name = "txtStreamTime";
            this.txtStreamTime.Size = new System.Drawing.Size(107, 13);
            this.txtStreamTime.TabIndex = 8;
            this.txtStreamTime.Text = "0 sec";
            this.txtStreamTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Total stream time :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Kbits/sec :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Bytes/sec :";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 63);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Framerate :";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 83);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "Strain :";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 103);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "Dropped frames :";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 123);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(94, 13);
            this.label12.TabIndex = 7;
            this.label12.Text = "Total frames :";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.btnToggleRecording);
            this.groupBox5.Controls.Add(this.btnToggleStreaming);
            this.groupBox5.Location = new System.Drawing.Point(684, 287);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(145, 82);
            this.groupBox5.TabIndex = 10;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Streaming / Recording";
            // 
            // btnToggleRecording
            // 
            this.btnToggleRecording.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnToggleRecording.Location = new System.Drawing.Point(7, 50);
            this.btnToggleRecording.Name = "btnToggleRecording";
            this.btnToggleRecording.Size = new System.Drawing.Size(132, 23);
            this.btnToggleRecording.TabIndex = 1;
            this.btnToggleRecording.Text = "State unknown";
            this.btnToggleRecording.UseVisualStyleBackColor = true;
            this.btnToggleRecording.Click += new System.EventHandler(this.btnToggleRecording_Click);
            // 
            // btnToggleStreaming
            // 
            this.btnToggleStreaming.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnToggleStreaming.Location = new System.Drawing.Point(7, 20);
            this.btnToggleStreaming.Name = "btnToggleStreaming";
            this.btnToggleStreaming.Size = new System.Drawing.Size(132, 23);
            this.btnToggleStreaming.TabIndex = 0;
            this.btnToggleStreaming.Text = "State unknown";
            this.btnToggleStreaming.UseVisualStyleBackColor = true;
            this.btnToggleStreaming.Click += new System.EventHandler(this.btnToggleStreaming_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnSetCurrentProfile);
            this.groupBox4.Controls.Add(this.btnGetCurrentProfile);
            this.groupBox4.Controls.Add(this.tbProfile);
            this.groupBox4.Controls.Add(this.btnListProfiles);
            this.groupBox4.Controls.Add(this.tvProfiles);
            this.groupBox4.Location = new System.Drawing.Point(6, 261);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(164, 243);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Profiles";
            // 
            // btnSetCurrentProfile
            // 
            this.btnSetCurrentProfile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSetCurrentProfile.Location = new System.Drawing.Point(88, 199);
            this.btnSetCurrentProfile.Name = "btnSetCurrentProfile";
            this.btnSetCurrentProfile.Size = new System.Drawing.Size(69, 38);
            this.btnSetCurrentProfile.TabIndex = 5;
            this.btnSetCurrentProfile.Text = "Set\r\nCurProfile";
            this.btnSetCurrentProfile.UseVisualStyleBackColor = true;
            this.btnSetCurrentProfile.Click += new System.EventHandler(this.btnSetCurrentProfile_Click);
            // 
            // btnGetCurrentProfile
            // 
            this.btnGetCurrentProfile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGetCurrentProfile.Location = new System.Drawing.Point(6, 199);
            this.btnGetCurrentProfile.Name = "btnGetCurrentProfile";
            this.btnGetCurrentProfile.Size = new System.Drawing.Size(69, 38);
            this.btnGetCurrentProfile.TabIndex = 4;
            this.btnGetCurrentProfile.Text = "Get\r\nCurProfile";
            this.btnGetCurrentProfile.UseVisualStyleBackColor = true;
            this.btnGetCurrentProfile.Click += new System.EventHandler(this.btnGetCurrentProfile_Click);
            // 
            // tbProfile
            // 
            this.tbProfile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbProfile.Location = new System.Drawing.Point(6, 173);
            this.tbProfile.Name = "tbProfile";
            this.tbProfile.Size = new System.Drawing.Size(151, 20);
            this.tbProfile.TabIndex = 3;
            // 
            // btnListProfiles
            // 
            this.btnListProfiles.Location = new System.Drawing.Point(6, 19);
            this.btnListProfiles.Name = "btnListProfiles";
            this.btnListProfiles.Size = new System.Drawing.Size(80, 23);
            this.btnListProfiles.TabIndex = 2;
            this.btnListProfiles.Text = "ListProfiles";
            this.btnListProfiles.UseVisualStyleBackColor = true;
            this.btnListProfiles.Click += new System.EventHandler(this.btnListProfiles_Click);
            // 
            // tvProfiles
            // 
            this.tvProfiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tvProfiles.Location = new System.Drawing.Point(6, 49);
            this.tvProfiles.Name = "tvProfiles";
            this.tvProfiles.Size = new System.Drawing.Size(152, 118);
            this.tvProfiles.TabIndex = 1;
            this.tvProfiles.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvProfiles_NodeMouseClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSetCurrentSceneCol);
            this.groupBox2.Controls.Add(this.btnGetCurrentSceneCol);
            this.groupBox2.Controls.Add(this.tbSceneCol);
            this.groupBox2.Controls.Add(this.btnListSceneCol);
            this.groupBox2.Controls.Add(this.tvSceneCols);
            this.groupBox2.Location = new System.Drawing.Point(176, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(192, 243);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Scene Collections";
            // 
            // btnSetCurrentSceneCol
            // 
            this.btnSetCurrentSceneCol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSetCurrentSceneCol.Location = new System.Drawing.Point(116, 199);
            this.btnSetCurrentSceneCol.Name = "btnSetCurrentSceneCol";
            this.btnSetCurrentSceneCol.Size = new System.Drawing.Size(69, 38);
            this.btnSetCurrentSceneCol.TabIndex = 5;
            this.btnSetCurrentSceneCol.Text = "Set\r\nCurSC";
            this.btnSetCurrentSceneCol.UseVisualStyleBackColor = true;
            this.btnSetCurrentSceneCol.Click += new System.EventHandler(this.btnSetCurrentSceneCol_Click);
            // 
            // btnGetCurrentSceneCol
            // 
            this.btnGetCurrentSceneCol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGetCurrentSceneCol.Location = new System.Drawing.Point(6, 199);
            this.btnGetCurrentSceneCol.Name = "btnGetCurrentSceneCol";
            this.btnGetCurrentSceneCol.Size = new System.Drawing.Size(69, 38);
            this.btnGetCurrentSceneCol.TabIndex = 4;
            this.btnGetCurrentSceneCol.Text = "Get\r\nCurSC";
            this.btnGetCurrentSceneCol.UseVisualStyleBackColor = true;
            this.btnGetCurrentSceneCol.Click += new System.EventHandler(this.btnGetCurrentSceneCol_Click);
            // 
            // tbSceneCol
            // 
            this.tbSceneCol.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSceneCol.Location = new System.Drawing.Point(6, 173);
            this.tbSceneCol.Name = "tbSceneCol";
            this.tbSceneCol.Size = new System.Drawing.Size(179, 20);
            this.tbSceneCol.TabIndex = 3;
            // 
            // btnListSceneCol
            // 
            this.btnListSceneCol.Location = new System.Drawing.Point(6, 19);
            this.btnListSceneCol.Name = "btnListSceneCol";
            this.btnListSceneCol.Size = new System.Drawing.Size(125, 23);
            this.btnListSceneCol.TabIndex = 2;
            this.btnListSceneCol.Text = "ListSceneCollections";
            this.btnListSceneCol.UseVisualStyleBackColor = true;
            this.btnListSceneCol.Click += new System.EventHandler(this.btnListSceneCol_Click);
            // 
            // tvSceneCols
            // 
            this.tvSceneCols.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tvSceneCols.Location = new System.Drawing.Point(6, 49);
            this.tvSceneCols.Name = "tvSceneCols";
            this.tvSceneCols.Size = new System.Drawing.Size(180, 118);
            this.tvSceneCols.TabIndex = 1;
            this.tvSceneCols.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvSceneCols_NodeMouseClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.tableLayoutPanel1);
            this.groupBox3.Location = new System.Drawing.Point(663, 193);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(166, 88);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Version Info";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 89F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tbOBSVersion, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.tbAPIVersion, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbPluginVersion, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(7, 19);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(153, 63);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tbOBSVersion
            // 
            this.tbOBSVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbOBSVersion.AutoSize = true;
            this.tbOBSVersion.Location = new System.Drawing.Point(92, 43);
            this.tbOBSVersion.Name = "tbOBSVersion";
            this.tbOBSVersion.Size = new System.Drawing.Size(58, 13);
            this.tbOBSVersion.TabIndex = 5;
            this.tbOBSVersion.Text = "???";
            this.tbOBSVersion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbAPIVersion
            // 
            this.tbAPIVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAPIVersion.AutoSize = true;
            this.tbAPIVersion.Location = new System.Drawing.Point(92, 23);
            this.tbAPIVersion.Name = "tbAPIVersion";
            this.tbAPIVersion.Size = new System.Drawing.Size(58, 13);
            this.tbAPIVersion.TabIndex = 4;
            this.tbAPIVersion.Text = "???";
            this.tbAPIVersion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbPluginVersion
            // 
            this.tbPluginVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPluginVersion.AutoSize = true;
            this.tbPluginVersion.Location = new System.Drawing.Point(92, 3);
            this.tbPluginVersion.Name = "tbPluginVersion";
            this.tbPluginVersion.Size = new System.Drawing.Size(58, 13);
            this.tbPluginVersion.TabIndex = 3;
            this.tbPluginVersion.Text = "???";
            this.tbPluginVersion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Plugin Version :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "OBS Version :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "API Version :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(377, 230);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "GetCurrentRTMPSettings";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 561);
            this.Controls.Add(this.gbControls);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtServerPassword);
            this.Controls.Add(this.txtServerIP);
            this.Controls.Add(this.btnConnect);
            this.Name = "MainWindow";
            this.Text = "obs-websocket client";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbControls.ResumeLayout(false);
            this.gbCustomRTMP.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbTransitionDuration)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.gbStatus.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox txtServerIP;
        private System.Windows.Forms.TextBox txtServerPassword;
        private System.Windows.Forms.TreeView tvScenes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnListScenes;
        private System.Windows.Forms.Button btnGetCurrentScene;
        private System.Windows.Forms.Button btnSetCurrentScene;
        private System.Windows.Forms.TextBox tbCurrentScene;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbControls;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label tbOBSVersion;
        private System.Windows.Forms.Label tbAPIVersion;
        private System.Windows.Forms.Label tbPluginVersion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnSetCurrentProfile;
        private System.Windows.Forms.Button btnGetCurrentProfile;
        private System.Windows.Forms.TextBox tbProfile;
        private System.Windows.Forms.Button btnListProfiles;
        private System.Windows.Forms.TreeView tvProfiles;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSetCurrentSceneCol;
        private System.Windows.Forms.Button btnGetCurrentSceneCol;
        private System.Windows.Forms.TextBox tbSceneCol;
        private System.Windows.Forms.Button btnListSceneCol;
        private System.Windows.Forms.TreeView tvSceneCols;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnToggleRecording;
        private System.Windows.Forms.Button btnToggleStreaming;
        private System.Windows.Forms.GroupBox gbStatus;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label txtTotalFrames;
        private System.Windows.Forms.Label txtDroppedFrames;
        private System.Windows.Forms.Label txtStrain;
        private System.Windows.Forms.Label txtFramerate;
        private System.Windows.Forms.Label txtBytesSec;
        private System.Windows.Forms.Label txtKbitsSec;
        private System.Windows.Forms.Label txtStreamTime;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnSetCurrentTransition;
        private System.Windows.Forms.Button btnGetCurrentTransition;
        private System.Windows.Forms.TextBox tbTransition;
        private System.Windows.Forms.Button btnListTransitions;
        private System.Windows.Forms.TreeView tvTransitions;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button btnSetTransitionDuration;
        private System.Windows.Forms.Button btnGetTransitionDuration;
        private System.Windows.Forms.NumericUpDown tbTransitionDuration;
        private System.Windows.Forms.GroupBox gbCustomRTMP;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnStartCommonStreaming;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnStartCustomStreaming;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.ComboBox comboCommonServer;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tbCommonKey;
        private System.Windows.Forms.ComboBox comboCommonService;
        private System.Windows.Forms.TextBox tbCustomStreamName;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.CheckBox cbUseAuth;
        private System.Windows.Forms.TextBox tbCustomServer;
        private System.Windows.Forms.TextBox tbCustomAuthUsername;
        private System.Windows.Forms.TextBox tbCustomAuthPassword;
        private System.Windows.Forms.Button button1;
    }
}

