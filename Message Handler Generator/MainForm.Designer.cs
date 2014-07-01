namespace Message_Handler_Generator
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_Info = new System.Windows.Forms.Label();
            this.button_Copy = new System.Windows.Forms.Button();
            this.button_Quit = new System.Windows.Forms.Button();
            this.groupBox_Search = new System.Windows.Forms.GroupBox();
            this.comboBox_Search = new System.Windows.Forms.ComboBox();
            this.groupBox_Search.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_Info
            // 
            this.label_Info.AutoSize = true;
            this.label_Info.Font = new System.Drawing.Font("굴림", 9F);
            this.label_Info.Location = new System.Drawing.Point(13, 13);
            this.label_Info.Name = "label_Info";
            this.label_Info.Size = new System.Drawing.Size(333, 48);
            this.label_Info.TabIndex = 0;
            this.label_Info.Text = "Please select or type message which is you want to use,\nAnd please press the \"Cop" +
    "y\" button,\nThen message handler will copy in your clipboard.\nIf you want to exit" +
    ", Please press the \"Quit\" button";
            this.label_Info.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button_Copy
            // 
            this.button_Copy.Location = new System.Drawing.Point(433, 8);
            this.button_Copy.Name = "button_Copy";
            this.button_Copy.Size = new System.Drawing.Size(75, 23);
            this.button_Copy.TabIndex = 1;
            this.button_Copy.Text = "Copy";
            this.button_Copy.UseVisualStyleBackColor = true;
            this.button_Copy.Click += new System.EventHandler(this.button_Copy_Click);
            // 
            // button_Quit
            // 
            this.button_Quit.Location = new System.Drawing.Point(433, 38);
            this.button_Quit.Name = "button_Quit";
            this.button_Quit.Size = new System.Drawing.Size(75, 23);
            this.button_Quit.TabIndex = 2;
            this.button_Quit.Text = "Quit";
            this.button_Quit.UseVisualStyleBackColor = true;
            this.button_Quit.Click += new System.EventHandler(this.button_Quit_Click);
            // 
            // groupBox_Search
            // 
            this.groupBox_Search.Controls.Add(this.comboBox_Search);
            this.groupBox_Search.Location = new System.Drawing.Point(15, 74);
            this.groupBox_Search.Name = "groupBox_Search";
            this.groupBox_Search.Size = new System.Drawing.Size(493, 58);
            this.groupBox_Search.TabIndex = 3;
            this.groupBox_Search.TabStop = false;
            this.groupBox_Search.Text = "Search message handler";
            // 
            // comboBox_Search
            // 
            this.comboBox_Search.FormattingEnabled = true;
            this.comboBox_Search.Items.AddRange(new object[] {
            "WM_COMPACTING",
            "WM_WININICHANGE",
            "WM_SYSCOLORCHANGE",
            "WM_QUERYNEWPALETTE",
            "WM_PALETTEISCHANGING",
            "WM_PALETTECHANGED",
            "WM_FONTCHANGE",
            "WM_SPOOLERSTATUS",
            "WM_DEVMODECHANGE",
            "WM_TIMECHANGE",
            "WM_POWER",
            "WM_QUERYENDSESSION",
            "WM_ENDSESSION",
            "WM_QUIT",
            "WM_SYSTEMERROR",
            "WM_CREATE",
            "WM_NCCREATE",
            "WM_DESTROY",
            "WM_NCDESTROY",
            "WM_SHOWWINDOW",
            "WM_SETREDRAW",
            "WM_ENABLE",
            "WM_SETTEXT",
            "WM_GETTEXT",
            "WM_GETTEXTLENGTH",
            "WM_WINDOWPOSCHANGING",
            "WM_WINDOWPOSCHANGED",
            "WM_MOVE",
            "WM_SIZE",
            "WM_CLOSE",
            "WM_QUERYOPEN",
            "WM_GETMINMAXINFO",
            "WM_PAINT",
            "WM_ERASEBKGND",
            "WM_ICONERASEBKGND",
            "WM_NCPAINT",
            "WM_NCCALCSIZE",
            "WM_NCHITTEST",
            "WM_QUERYDRAGICON",
            "WM_DROPFILES",
            "WM_ACTIVATE",
            "WM_ACTIVATEAPP",
            "WM_NCACTIVATE",
            "WM_SETFOCUS",
            "WM_KILLFOCUS",
            "WM_KEYDOWN",
            "WM_KEYUP",
            "WM_CHAR",
            "WM_DEADCHAR",
            "WM_SYSKEYDOWN",
            "WM_SYSKEYUP",
            "WM_SYSCHAR",
            "WM_SYSDEADCHAR",
            "WM_MOUSEMOVE",
            "WM_LBUTTONDOWN",
            "WM_LBUTTONDBLCLK",
            "WM_LBUTTONUP",
            "WM_RBUTTONDOWN",
            "WM_RBUTTONDBLCLK",
            "WM_RBUTTONUP",
            "WM_MBUTTONDOWN",
            "WM_MBUTTONDBLCLK",
            "WM_MBUTTONUP",
            "WM_MOUSEWHEEL",
            "WM_NCMOUSEMOVE",
            "WM_NCLBUTTONDOWN",
            "WM_NCLBUTTONDBLCLK",
            "WM_NCLBUTTONUP",
            "WM_NCRBUTTONDOWN",
            "WM_NCRBUTTONDBLCLK",
            "WM_NCRBUTTONDBLCLK",
            "WM_NCMBUTTONDOWN",
            "WM_NCMBUTTONDBLCLK",
            "WM_NCMBUTTONUP",
            "WM_MOUSEACTIVATE",
            "WM_CANCELMODE",
            "WM_TIMER",
            "WM_INITMENU",
            "WM_INITMENUPOPUP",
            "WM_MENUSELECT",
            "WM_MENUCHAR",
            "WM_COMMAND",
            "WM_HSCROLL",
            "WM_VSCROLL",
            "WM_CUT",
            "WM_COPY",
            "WM_PASTE",
            "WM_CLEAR",
            "WM_UNDO",
            "WM_RENDERFORMAT",
            "WM_RENDERALLFORMATS",
            "WM_RENDERALLFORMATS",
            "WM_DRAWCLIPBOARD",
            "WM_PAINTCLIPBOARD",
            "WM_SIZECLIPBOARD",
            "WM_VSCROLLCLIPBOARD",
            "WM_HSCROLLCLIPBOARD",
            "WM_ASKCBFORMATNAME",
            "WM_CHANGECBCHAIN",
            "WM_SETCURSOR",
            "WM_SYSCOMMAND",
            "WM_MDICREATE",
            "WM_MDIDESTROY",
            "WM_MDIACTIVATE",
            "WM_MDIRESTORE",
            "WM_MDINEXT",
            "WM_MDIMAXIMIZE",
            "WM_MDITILE",
            "WM_MDICASCADE",
            "WM_MDIICONARRANGE",
            "WM_MDIGETACTIVE",
            "WM_MDISETMENU",
            "WM_CHILDACTIVATE",
            "WM_INITDIALOG",
            "WM_NEXTDLGCTL",
            "WM_PARENTNOTIFY",
            "WM_ENTERIDLE",
            "WM_GETDLGCODE",
            "WM_CTLCOLORMSGBOX",
            "WM_CTLCOLOREDIT",
            "WM_CTLCOLORLISTBOX",
            "WM_CTLCOLORBTN",
            "WM_CTLCOLORDLG",
            "WM_CTLCOLORSCROLLBAR",
            "WM_CTLCOLORSTATIC",
            "WM_SETFONT",
            "WM_GETFONT",
            "WM_DRAWITEM",
            "WM_MEASUREITEM",
            "WM_DELETEITEM",
            "WM_COMPAREITEM",
            "WM_VKEYTOITEM",
            "WM_CHARTOITEM",
            "WM_QUEUESYNC",
            "WM_COMMNOTIFY",
            "WM_DISPLAYCHANGE",
            "WM_DEVICECHANGE",
            "WM_CONTEXTMENU",
            "WM_COPYDATA",
            "WM_HOTKEY"});
            this.comboBox_Search.Location = new System.Drawing.Point(7, 21);
            this.comboBox_Search.Name = "comboBox_Search";
            this.comboBox_Search.Size = new System.Drawing.Size(480, 20);
            this.comboBox_Search.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 144);
            this.Controls.Add(this.groupBox_Search);
            this.Controls.Add(this.button_Quit);
            this.Controls.Add(this.button_Copy);
            this.Controls.Add(this.label_Info);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Message Handler Generator";
            this.groupBox_Search.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Info;
        private System.Windows.Forms.Button button_Copy;
        private System.Windows.Forms.Button button_Quit;
        private System.Windows.Forms.GroupBox groupBox_Search;
        private System.Windows.Forms.ComboBox comboBox_Search;
    }
}

