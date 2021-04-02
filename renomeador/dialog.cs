using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace renomeador
{
    class dialog
    {
        public static FolderBrowserDialog browser()
        {
            FolderBrowserDialog dialog = null;
            //Necessário executar uma thread para que as páginas Web reconhecerem o FileDialog
            Thread td = new Thread
            (
                //Inicia a Thread
                () =>
                {
                    dialog = new FolderBrowserDialog();
                    if (dialog.ShowDialog() != DialogResult.OK)
                        dialog = null;
                }
            );
            //Configurações necessárias para funcionar a Thread
            td.SetApartmentState(ApartmentState.STA);
            td.IsBackground = true;
            td.Start();
            td.Join();

            return dialog;
        }
    }
}
