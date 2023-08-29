
namespace Elev8WinService
{
    partial class Elev8Service
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
            this.components = new System.ComponentModel.Container();
            this.elev8Timer = new System.Windows.Forms.Timer(this.components);
            // 
            // elev8Timer
            // 
            this.elev8Timer.Interval = 5000;
            this.elev8Timer.Tick += new System.EventHandler(this.elev8Timer_Tick);
            // 
            // Elev8Service
            // 
            this.ServiceName = "Elev8WinService";

        }

        #endregion

        private System.Windows.Forms.Timer elev8Timer;
    }
}
