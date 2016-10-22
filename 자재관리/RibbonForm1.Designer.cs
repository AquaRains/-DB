namespace 자재관리
{
    partial class RibbonForm1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.XtraBars.Ribbon.ReduceOperation reduceOperation1 = new DevExpress.XtraBars.Ribbon.ReduceOperation();
            DevExpress.XtraBars.Ribbon.ReduceOperation reduceOperation2 = new DevExpress.XtraBars.Ribbon.ReduceOperation();
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnClose = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonGroup1 = new DevExpress.XtraBars.BarButtonGroup();
            this.btn지역 = new DevExpress.XtraBars.BarButtonItem();
            this.btn물품 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.btnClose,
            this.barButtonGroup1,
            this.btn지역,
            this.btn물품});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 6;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2,
            this.ribbonPage3});
            this.ribbon.Size = new System.Drawing.Size(1038, 170);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // btnClose
            // 
            this.btnClose.Caption = "닫기";
            this.btnClose.Id = 11;
            this.btnClose.Name = "btnClose";
            this.btnClose.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnClose.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnClose_ItemClick);
            // 
            // barButtonGroup1
            // 
            this.barButtonGroup1.Caption = "barButtonGroup1";
            this.barButtonGroup1.Id = 3;
            this.barButtonGroup1.ItemLinks.Add(this.btn지역);
            this.barButtonGroup1.ItemLinks.Add(this.btn물품);
            this.barButtonGroup1.Name = "barButtonGroup1";
            // 
            // btn지역
            // 
            this.btn지역.Caption = "지역코드";
            this.btn지역.Id = 4;
            this.btn지역.Name = "btn지역";
            this.btn지역.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btn지역.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn지역_ItemClick);
            // 
            // btn물품
            // 
            this.btn물품.Caption = "물품 데이터";
            this.btn물품.Id = 5;
            this.btn물품.Name = "btn물품";
            this.btn물품.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btn물품.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn물품_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.ribbonPageGroup3});
            this.ribbonPage1.Name = "ribbonPage1";
            reduceOperation1.Behavior = DevExpress.XtraBars.Ribbon.ReduceOperationBehavior.Single;
            reduceOperation1.Group = null;
            reduceOperation1.ItemLinkIndex = 0;
            reduceOperation1.ItemLinksCount = 0;
            reduceOperation1.Operation = DevExpress.XtraBars.Ribbon.ReduceOperationType.LargeButtons;
            reduceOperation2.Behavior = DevExpress.XtraBars.Ribbon.ReduceOperationBehavior.Single;
            reduceOperation2.Group = null;
            reduceOperation2.ItemLinkIndex = 0;
            reduceOperation2.ItemLinksCount = 0;
            reduceOperation2.Operation = DevExpress.XtraBars.Ribbon.ReduceOperationType.SmallButtonsWithText;
            this.ribbonPage1.ReduceOperations.Add(reduceOperation1);
            this.ribbonPage1.ReduceOperations.Add(reduceOperation2);
            this.ribbonPage1.Text = "파일";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "ribbonPageGroup2";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnClose);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup4});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "데이터입력 및 관리";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.btn지역);
            this.ribbonPageGroup4.ItemLinks.Add(this.btn물품);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "데이터";
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "ribbonPage3";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 671);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1038, 39);
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.EnableBonusSkins = global::자재관리.Properties.Settings.Default.EnableSkin;
            this.defaultLookAndFeel1.LookAndFeel.SkinMaskColor = System.Drawing.Color.Transparent;
            this.defaultLookAndFeel1.LookAndFeel.SkinMaskColor2 = System.Drawing.Color.Transparent;
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Metropolis";
            // 
            // RibbonForm1
            // 
            this.AllowMdiBar = true;
            this.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(1038, 710);
            this.ControlBox = false;
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Font = global::자재관리.Properties.Settings.Default.폰트;
            this.IsMdiContainer = true;
            this.Name = "RibbonForm1";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "RibbonForm1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem btnClose;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonGroup barButtonGroup1;
        private DevExpress.XtraBars.BarButtonItem btn지역;
        private DevExpress.XtraBars.BarButtonItem btn물품;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
    }
}