
namespace Elev8WinService
{
    partial class ProjectInstaller
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.elev8ProcessInstaller = new System.ServiceProcess.ServiceProcessInstaller();
            this.elev8ServiceInstaller = new System.ServiceProcess.ServiceInstaller();
            // 
            // elev8ProcessInstaller
            // 
            this.elev8ProcessInstaller.Account = System.ServiceProcess.ServiceAccount.LocalSystem;
            this.elev8ProcessInstaller.Password = null;
            this.elev8ProcessInstaller.Username = null;
            // 
            // elev8ServiceInstaller
            // 
            this.elev8ServiceInstaller.DelayedAutoStart = true;
            this.elev8ServiceInstaller.Description = "Elev8 service for classes";
            this.elev8ServiceInstaller.DisplayName = "Elev8 Win. Service";
            this.elev8ServiceInstaller.ServiceName = "Elev8WinService";
            this.elev8ServiceInstaller.StartType = System.ServiceProcess.ServiceStartMode.Automatic;
            // 
            // ProjectInstaller
            // 
            this.Installers.AddRange(new System.Configuration.Install.Installer[] {
            this.elev8ProcessInstaller,
            this.elev8ServiceInstaller});

        }

        #endregion

        private System.ServiceProcess.ServiceProcessInstaller elev8ProcessInstaller;
        private System.ServiceProcess.ServiceInstaller elev8ServiceInstaller;
    }
}