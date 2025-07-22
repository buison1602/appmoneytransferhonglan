using Microsoft.JSInterop;

namespace AppMoneyTransferRS.PDF
{
    public class PDFGenerator
    {
        public void DownloadPdf(IJSRuntime js, String FileName="Receipt.pdf")
        {

        }
        public void ViewPDF(IJSRuntime js, String File, String IdFrame)
        {
            try
            {
                js.InvokeVoidAsync("ViewPdf", IdFrame, File);
            }            
            catch(Exception ex)
            { }
        }
        public void ViewPDFNewTab(IJSRuntime js, String FileName = "Receipt.pdf")
        {

        }
    }
}
