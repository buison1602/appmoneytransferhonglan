using Microsoft.JSInterop;
using AppMoneyTransferRS.Models;
using static MudBlazor.CategoryTypes;

namespace AppMoneyTransferRS.XLS
{
    public class Excel
    {
        public async Task ExcelUserList(IJSRuntime js, List<UserListModel> ReportDetailAll, string filename = "ExcelUserList")
        {
            var weatherForecast = new WeatherForecastXLS();
            var XLSStream = weatherForecast.ExportExcelUserList(ReportDetailAll, filename);

            await js.InvokeVoidAsync("BlazorDownloadFile", filename, XLSStream);
        }
        public async Task ExcelTransactionCN4(IJSRuntime js, List<batchTransactionFileExportModel> ReportDetailAll, string filename = "ExportTransactionCN4")
        {
            var weatherForecast = new WeatherForecastXLS();
            var XLSStream = weatherForecast.ExportExcelTransactionCN4(ReportDetailAll, filename);

            await js.InvokeVoidAsync("BlazorDownloadFile", filename, XLSStream);
        }
        public async Task ExcelTransactionCN10(IJSRuntime js, List<batchTransactionFileExportModel> ReportDetailAll, string filename = "ExportTransactionCN10")
        {
            var weatherForecast = new WeatherForecastXLS();
            var XLSStream = weatherForecast.ExportExcelTransactionCN10(ReportDetailAll, filename);

            await js.InvokeVoidAsync("BlazorDownloadFile", filename, XLSStream);
        }
        public async Task ExcelTransactionCN12(IJSRuntime js, List<batchTransactionFileExportModel> ReportDetailAll, string filename = "ExportTransactionCN10")
        {
            var weatherForecast = new WeatherForecastXLS();
            var XLSStream = weatherForecast.ExportExcelTransactionCN12(ReportDetailAll, filename);

            await js.InvokeVoidAsync("BlazorDownloadFile", filename, XLSStream);
        }
        public async Task ExcelTransactionCN9(IJSRuntime js, List<batchTransactionFileExportModel> ReportDetailAll, string filename = "ExportTransactionCN9")
        {
            var weatherForecast = new WeatherForecastXLS();
            var XLSStream = weatherForecast.ExportExcelTransactionCN9(ReportDetailAll, filename);

            await js.InvokeVoidAsync("BlazorDownloadFile", filename, XLSStream);
        }
        public async Task ExcelTransactionCN2(IJSRuntime js, List<batchTransactionFileExportModel> ReportDetailAll, string filename = "ExportTransactionCN2")
        {
            var weatherForecast = new WeatherForecastXLS();
            var XLSStream = weatherForecast.ExportExcelTransactionCN2(ReportDetailAll, filename);

            await js.InvokeVoidAsync("BlazorDownloadFile", filename, XLSStream);
        }
        public async Task ExcelTransactionCN8(IJSRuntime js, List<batchTransactionFileExportModel> ReportDetailAll, string filename = "ExportTransactionCN8")
        {
            var weatherForecast = new WeatherForecastXLS();
            var XLSStream = weatherForecast.ExportExcelTransactionCN8(ReportDetailAll, filename);

            await js.InvokeVoidAsync("BlazorDownloadFile", filename, XLSStream);
        }
        public async Task ExcelQuickbookDomestic(IJSRuntime js, List<QuickbookCounterData> ReportDetailAll, string filename = "QuickBookDomestic")
        {
            var weatherForecast = new WeatherForecastXLS();
            var XLSStream = weatherForecast.ExportExcelQuickBookOnlineDebit(ReportDetailAll, filename);

            await js.InvokeVoidAsync("BlazorDownloadFile", filename, XLSStream);
        }
        public async Task ExcelQuickbookOnlineDebit(IJSRuntime js, List<QuickbookCounterData> ReportDetailAll, string filename = "QuickBookOnlineDebit")
        {
            var weatherForecast = new WeatherForecastXLS();
            var XLSStream = weatherForecast.ExportExcelQuickBookOnlineDebit(ReportDetailAll, filename);

            await js.InvokeVoidAsync("BlazorDownloadFile", filename, XLSStream);
        }
        public async Task ExcelQuickbookHLDebit(IJSRuntime js, List<QuickbookCounterData> ReportDetailAll, string filename = "ExportTranstoQBHLDebit")
        {
            var weatherForecast = new WeatherForecastXLS();
            var XLSStream = weatherForecast.ExportExcelQuickBookHLDebit(ReportDetailAll, filename);

            await js.InvokeVoidAsync("BlazorDownloadFile", filename, XLSStream);
        }
        public async Task ExcelQuickbookCounter(IJSRuntime js, List<QuickbookCounterData> ReportDetailAll, string filename = "QuickBookCounter")
        {
            var weatherForecast = new WeatherForecastXLS();
            var XLSStream = weatherForecast.ExportExcelQuickBookCounter(ReportDetailAll, filename);

            await js.InvokeVoidAsync("BlazorDownloadFile", filename, XLSStream);
        }
        public async Task ExportDatatoExcelIdology(IJSRuntime js, List<ReportDetail> ReportDetailAll, string filename = "IdologyReport")
        {
            var weatherForecast = new WeatherForecastXLS();
            var XLSStream = weatherForecast.ExportIdologytoExcelReport(ReportDetailAll, filename);

            await js.InvokeVoidAsync("BlazorDownloadFile", filename, XLSStream);
        }
        public async Task ExportDatatoExcelReport(IJSRuntime js, List<ReportDetailExport> ReportDetailAll, string filename = "ExportDatatoExcelReport")
        {
            var weatherForecast = new WeatherForecastXLS();
            var XLSStream = weatherForecast.ExportDatatoExcelReport(ReportDetailAll, filename);

            await js.InvokeVoidAsync("BlazorDownloadFile", filename, XLSStream);
        }
        public async Task ExportDataMTtoExcelReport(IJSRuntime js, List<ReportDetailExport> ReportDetailAll, string filename = "ExportDatatoExcelReport")
        {
            var weatherForecast = new WeatherForecastXLS();
            var XLSStream = weatherForecast.ExportDataMTtoExcelReport(ReportDetailAll, filename);

            await js.InvokeVoidAsync("BlazorDownloadFile", filename, XLSStream);
        }
        public async Task ExportKYCReporttoExcel(IJSRuntime js, List<ReportDetail> ReportDetailAll, string filename = "ExportKYCReporttoExcel")
        {
            var weatherForecast = new WeatherForecastXLS();
            var XLSStream = weatherForecast.ExportKYCReporttoExcel(ReportDetailAll, filename);

            await js.InvokeVoidAsync("BlazorDownloadFile", filename, XLSStream);
        }
        public async Task ExportReviewPaymentTransactiontoExcel(IJSRuntime js, List<ReportDetailExport> ReportDetailAll, string filename = "ExportReviewPaymentExcel")
        {
            var weatherForecast = new WeatherForecastXLS();
            var XLSStream = weatherForecast.ExportReviewPaymentTransactiontoExcel(ReportDetailAll, filename);

            await js.InvokeVoidAsync("BlazorDownloadFile", filename, XLSStream);
        }
        public async Task ExportReviewDMTransactiontoExcel(IJSRuntime js, List<ReportDetailExport> ReportDetailAll, string filename = "ExportReviewDMtoExcel")
        {
            var weatherForecast = new WeatherForecastXLS();
            var XLSStream = weatherForecast.ExportReviewDMTransactiontoExcel(ReportDetailAll, filename);

            await js.InvokeVoidAsync("BlazorDownloadFile", filename, XLSStream);
        }
        public async Task ExportHoldingtoExcel(IJSRuntime js, List<ReportDetail> ReportDetailAll, string filename = "ExportHoldingtoExcel")
        {
            var weatherForecast = new WeatherForecastXLS();
            var XLSStream = weatherForecast.ExportHoldingtoExcel(ReportDetailAll, filename);

            await js.InvokeVoidAsync("BlazorDownloadFile", filename, XLSStream);
        }
        public async Task ExportReleaseHoldingtoExcel(IJSRuntime js, List<ReportDetailExport> ReportDetailAll, string filename = "ExportReleaseHoldingtoExcel")
        {
            var weatherForecast = new WeatherForecastXLS();
            var XLSStream = weatherForecast.ExportReleaseHoldingtoExcel(ReportDetailAll, filename);

            await js.InvokeVoidAsync("BlazorDownloadFile", filename, XLSStream);
        }
        public async Task ExportOFACReporttoExcel(IJSRuntime js, List<ReportDetailExport> ReportDetailAll, string filename = "ExportReleaseHoldingtoExcel")
        {
            var weatherForecast = new WeatherForecastXLS();
            var XLSStream = weatherForecast.ExportOFACReporttoExcel(ReportDetailAll, filename);

            await js.InvokeVoidAsync("BlazorDownloadFile", filename, XLSStream);
        }
        public async Task ExportApproveTransactiontoExcel(IJSRuntime js, List<ReportDetailExport> ReportDetailAll, string filename = "ExportPaymentAgentExcel")
        {
            var weatherForecast = new WeatherForecastXLS();
            var XLSStream = weatherForecast.ExportApproveTransactiontoExcel(ReportDetailAll, filename);

            await js.InvokeVoidAsync("BlazorDownloadFile", filename, XLSStream);
        }
        public async Task ExportPaymentAgentTransactiontoExcel(IJSRuntime js, List<ReportDetailExport> ReportDetailAll, string filename = "ExportPaymentAgentExcel")
        {
            var weatherForecast = new WeatherForecastXLS();
            var XLSStream = weatherForecast.ExportPaymentAgentTransactiontoExcel(ReportDetailAll, filename);

            await js.InvokeVoidAsync("BlazorDownloadFile", filename, XLSStream);
        }
        public async Task ExportDatatoExcelReportVN(IJSRuntime js, List<ReportDetailExport> ReportDetailAll, string filename = "ExportDataExcelReportVN")
        {
            var weatherForecast = new WeatherForecastXLS();
            var XLSStream = weatherForecast.ExportDatatoExcelReportVN(ReportDetailAll, filename);

            await js.InvokeVoidAsync("BlazorDownloadFile", filename, XLSStream);
        }
        public async Task ExportDatatoExcelReportPayment(IJSRuntime js, List<ReportDetailExport> ReportDetailAll, string filename = "ExportDataExcelPayment")
        {
            var weatherForecast = new WeatherForecastXLS();
            var XLSStream = weatherForecast.ExportDatatoExcelPayment(ReportDetailAll, filename);

            await js.InvokeVoidAsync("BlazorDownloadFile", filename, XLSStream);
        }
        public async Task GenerateExportExcelReport(IJSRuntime js, List<ReportDetail> ReportDetailAll, string filename = "ExportExcelReport")
        {
            var weatherForecast = new WeatherForecastXLS();
            var XLSStream = weatherForecast.ExportExcelReport(ReportDetailAll, filename);

            await js.InvokeVoidAsync("BlazorDownloadFile", filename, XLSStream);
        }
        public async Task ExportSenderHistory(IJSRuntime js, List<HistoryCustomerSendTran> ReportDetailAll, string filename = "ExportExcelReport")
        {
            var weatherForecast = new WeatherForecastXLS();
            var XLSStream = weatherForecast.ExportExcelSenderHistoryReport(ReportDetailAll, filename);

            await js.InvokeVoidAsync("BlazorDownloadFile", filename, XLSStream);
        }
        public async Task GenerateExportRequestRefund(IJSRuntime js, List<ReportRefundDetail> ReportDetailAll, string filename = "ExportExcelReport")
        {
            var weatherForecast = new WeatherForecastXLS();
            var XLSStream = weatherForecast.ExportRequestRefundReport(ReportDetailAll, filename);

            await js.InvokeVoidAsync("BlazorDownloadFile", filename, XLSStream);
        }
        public async Task GenerateFeedBackTransactionAsync(IJSRuntime js, List<ReportDetail> ReportDetailAll, string filename = "FeedBackTransaction")
        {
            var weatherForecast = new WeatherForecastXLS();
            var XLSStream = weatherForecast.FeedBackTransactionExcel(ReportDetailAll, "FeedBackTransaction");

            await js.InvokeVoidAsync("BlazorDownloadFile", filename, XLSStream);
        }
        public async Task GeneratePendingTransactionAsync(IJSRuntime js, List<ReportDetail> ReportDetailAll, string filename = "PendingTransaction")
        {
            var weatherForecast = new WeatherForecastXLS();
            var XLSStream = weatherForecast.PendingTransactionExcel(ReportDetailAll, "PendingTransaction");

            await js.InvokeVoidAsync("BlazorDownloadFile", filename, XLSStream);
        }
        
            public async Task PendingInstoreTransactionAsync(IJSRuntime js, List<ReportDetail> ReportDetailAll, string filename = "PendingInstoreTransaction")
        {
            var weatherForecast = new WeatherForecastXLS();
            var XLSStream = weatherForecast.PendingInstoreTransaction(ReportDetailAll, "PendingInstoreTransaction");

            await js.InvokeVoidAsync("BlazorDownloadFile", filename, XLSStream);
        }
        public async Task GenerateWeatherForecastAsync(IJSRuntime js, List<ReportDetail> ReportDetailAll, string filename = "GeneralDailyReport")
        {
            var weatherForecast = new WeatherForecastXLS();
            var XLSStream = weatherForecast.GeneralDailyReportExcel(ReportDetailAll, "GeneralDailyReport");

            await js.InvokeVoidAsync("BlazorDownloadFile", filename, XLSStream);
        }
        public async Task CTRsReviewAsync(IJSRuntime js, List<ReportDetail> ReportDetailAll, string filename = "CTRsReviewExcel")
        {
            var weatherForecast = new WeatherForecastXLS();
            var XLSStream = weatherForecast.CTRsReviewExcel(ReportDetailAll, "CTRsReviewExcel");

            await js.InvokeVoidAsync("BlazorDownloadFile", filename, XLSStream);
        }
        public async Task CTRsReportAsync(IJSRuntime js, List<ReportDetail> ReportDetailAll, string filename = "CTRsReport")
        {
            var weatherForecast = new WeatherForecastXLS();
            var XLSStream = weatherForecast.CTRsReportExcel(ReportDetailAll, "CTRsReport");

            await js.InvokeVoidAsync("BlazorDownloadFile", filename, XLSStream);
        }
        public async Task SARsReportAsync(IJSRuntime js, List<ReportDetail> ReportDetailAll, string filename = "SARsReport")
        {
            var weatherForecast = new WeatherForecastXLS();
            var XLSStream = weatherForecast.SARsReportExcel(ReportDetailAll, "SARsReport");

            await js.InvokeVoidAsync("BlazorDownloadFile", filename, XLSStream);
        }
        public async Task GenerateSARsAsync(IJSRuntime js, List<ReportDetail> ReportDetailAll, string filename = "SARsExcel", 
            bool chkS_Name=false, bool chkS_Address = false, bool chkS_Phone = false, bool chkID = false, bool chkSS = false, bool chkRe_Name = false,
            bool chkRe_Address = false, bool chkRe_Phone = false, bool chkAccount = false, bool chkPassport = false)
        {
            var weatherForecast = new WeatherForecastXLS();
            var XLSStream = weatherForecast.SARsExcel(ReportDetailAll, "SARsExcel",
             chkS_Name,  chkS_Address ,  chkS_Phone,  chkID,  chkSS,  chkRe_Name ,
             chkRe_Address,chkRe_Phone ,  chkAccount ,  chkPassport );

            await js.InvokeVoidAsync("BlazorDownloadFile", filename, XLSStream);
        }
        public async Task KYCReportExcelAsync(IJSRuntime js, List<ReportDetail> ReportDetailAll, string filename = "ProcessKYCExcel")
        {
            var weatherForecast = new WeatherForecastXLS();
            var XLSStream = weatherForecast.KYCReportExcel(ReportDetailAll, "ProcessKYCExcel");

            await js.InvokeVoidAsync("BlazorDownloadFile", filename, XLSStream);
        }
        
        public async Task TransactionForecastAsync(IJSRuntime js, List<ReportDetail> ReportDetailAll, string filename = "TransactionStatus")
        {
            var weatherForecast = new WeatherForecastXLS();
            var XLSStream = weatherForecast.TransactionStatusExcel(ReportDetailAll, "TransactionStatus");

            await js.InvokeVoidAsync("BlazorDownloadFile", filename, XLSStream);
        }
        public async Task AdPhoneAsync(IJSRuntime js, List<ReportDetail> ReportDetailAll, string filename = "GetAdPhone")
        {
            var weatherForecast = new WeatherForecastXLS();
            var XLSStream = weatherForecast.AdPhoneExcel(ReportDetailAll, "GetAdPhone");

            await js.InvokeVoidAsync("BlazorDownloadFile", filename, XLSStream);
        }
        public async Task TransactionVolunmReportAsync(IJSRuntime js, List<ReportDetail> ReportDetailAll, string filename = "TransactionVolumnReport")
        {
            var weatherForecast = new WeatherForecastXLS();
            var XLSStream = weatherForecast.TransactionVolunmReportExcel(ReportDetailAll, "TransactionVolumnReport");

            await js.InvokeVoidAsync("BlazorDownloadFile", filename, XLSStream);
        }
        public async Task BlockCustomerReportAsync(IJSRuntime js, List<ReportDetail> ReportDetailAll, string filename = "BlockCustomerReport")
        {
            var weatherForecast = new WeatherForecastXLS();
            var XLSStream = weatherForecast.BlockCustomerReportExcel(ReportDetailAll, "BlockCustomerReport");

            await js.InvokeVoidAsync("BlazorDownloadFile", filename, XLSStream);
        }
        public async Task DownloadRateAsync(IJSRuntime js, List<AgentRateModel> ReportDetailAll, string filename = "DownLoadAgentRate")
        {
            var weatherForecast = new WeatherForecastXLS();
            var XLSStream = weatherForecast.ExportExcelAgentRate(ReportDetailAll, "DownLoadAgentRate");

            await js.InvokeVoidAsync("BlazorDownloadFile", filename, XLSStream);
        }
        public async Task DownloadHongLanBlackListAsync(IJSRuntime js, List<HongLanBlackListModel> ReportDetailAll, string filename = "HongLanBlackList")
        {
            var weatherForecast = new WeatherForecastXLS();
            var XLSStream = weatherForecast.ExportExcelHongLanBlackList(ReportDetailAll, "HongLanBlackList");

            await js.InvokeVoidAsync("BlazorDownloadFile", filename, XLSStream);
        }
        public async Task DownloadCollectListAsync(IJSRuntime js, List<ReportDetail> ReportDetailAll, string filename = "CollectList")
        {
            var weatherForecast = new WeatherForecastXLS();
            var XLSStream = weatherForecast.ExportExcelCollectList(ReportDetailAll, "HongLanBlackList");

            await js.InvokeVoidAsync("BlazorDownloadFile", filename, XLSStream);
        }
        public async Task DownloadOfacListAsync(IJSRuntime js, List<OfacModel> ReportDetailAll, string filename = "OFACList")
        {
            var weatherForecast = new WeatherForecastXLS();
            var XLSStream = weatherForecast.ExportExcelOFACList(ReportDetailAll, "OFACList");

            await js.InvokeVoidAsync("BlazorDownloadFile", filename, XLSStream);
        }
        public async Task DownloadAMLTrainingLogDetailListAsync(IJSRuntime js, List<AMLTrainingLogModel> ReportDetailAll, string filename = "AMLTrainingLogDetailList")
        {
            var weatherForecast = new WeatherForecastXLS();
            var XLSStream = weatherForecast.ExportExcelAMLTrainingDetailLogList(ReportDetailAll, "AMLTrainingLogDetailList");

            await js.InvokeVoidAsync("BlazorDownloadFile", filename, XLSStream);
        }
        public async Task DownloadAMLTrainingLogListAsync(IJSRuntime js, List<AMLTrainingLogModel> ReportDetailAll, string filename = "AMLTrainingLogList")
        {
            var weatherForecast = new WeatherForecastXLS();
            var XLSStream = weatherForecast.ExportExcelAMLTrainingLogList(ReportDetailAll, "AMLTrainingLogList");

            await js.InvokeVoidAsync("BlazorDownloadFile", filename, XLSStream);
        }
        public async Task DownloadRiskAssetmentListAsync(IJSRuntime js, List<RiskAssessmentModel> ReportDetailAll, string filename = "AMLTrainingLogList")
        {
            var weatherForecast = new WeatherForecastXLS();
            var XLSStream = weatherForecast.ExportExcelRiskAssetmentList(ReportDetailAll, "AMLTrainingLogList");

            await js.InvokeVoidAsync("BlazorDownloadFile", filename, XLSStream);
        }
        public async Task DownloadAtgentListforFinCENAsync(IJSRuntime js, List<AgentModel> ReportDetailAll, string filename = "AgentListforFinCEN")
        {
            var weatherForecast = new WeatherForecastXLS();
            var XLSStream = weatherForecast.ExportExcelAgentListforFinCENList(ReportDetailAll, "AgentListforFinCEN");

            await js.InvokeVoidAsync("BlazorDownloadFile", filename, XLSStream);
        }
        public async Task DownloadAgentListAsync(IJSRuntime js, List<AgentModel> ReportDetailAll, string filename = "AgentList")
        {
            var weatherForecast = new WeatherForecastXLS();
            var XLSStream = weatherForecast.ExportExcelAgentListList(ReportDetailAll, "AgentList");

            await js.InvokeVoidAsync("BlazorDownloadFile", filename, XLSStream);
        }
        public async Task DownloadSetUpRiskAssetmentListAsync(IJSRuntime js, List<SetRiskAssetmentDetail> reportDetails, List<SetRiskAssetmentSum> reportSummarys, string filename = "SetUpRiskAssetmentList")
        {
            var weatherForecast = new WeatherForecastXLS();
            var XLSStream = weatherForecast.ExportExcelSetUpRiskAssetmentList(reportDetails, reportSummarys, "SetUpRiskAssetmentList");

            await js.InvokeVoidAsync("BlazorDownloadFile", filename, XLSStream);
        }
        public async Task DownloadIndependentReviewListAsync(IJSRuntime js, List<IndependentReviewModel> ReportDetailAll, string filename = "IndependentReviewList")
        {
            var weatherForecast = new WeatherForecastXLS();
            var XLSStream = weatherForecast.ExportExcelIndependentReviewList(ReportDetailAll, "IndependentReviewList");

            await js.InvokeVoidAsync("BlazorDownloadFile", filename, XLSStream);
        }
        public async Task DownloadComplianceListAsync(IJSRuntime js, List<ComplianceModel> ReportDetailAll, string filename = "ComplianceList")
        {
            var weatherForecast = new WeatherForecastXLS();
            var XLSStream = weatherForecast.ExportExcelComplianceList(ReportDetailAll, "ComplianceList");

            await js.InvokeVoidAsync("BlazorDownloadFile", filename, XLSStream);
        }
        public async Task DownloadComplianceSubmitListAsync(IJSRuntime js, List<ComplianceSubmitModel> ReportDetailAll, string filename = "ComplianceList")
        {
            var weatherForecast = new WeatherForecastXLS();
            var XLSStream = weatherForecast.ExportExcelComplianceSubmitList(ReportDetailAll, "ComplianceList");

            await js.InvokeVoidAsync("BlazorDownloadFile", filename, XLSStream);
        }
        public async Task DownloadAMLMaterialListAsync(IJSRuntime js, List<AMLMaterialModel> ReportDetailAll, string filename = "AMLMaterialList")
        {
            var weatherForecast = new WeatherForecastXLS();
            var XLSStream = weatherForecast.ExportExcelAmlMaterialList(ReportDetailAll, "AMLMaterialList");

            await js.InvokeVoidAsync("BlazorDownloadFile", filename, XLSStream);
        }
       
        public async Task DownloadAMLTestListAsync(IJSRuntime js, List<AMLTestModel> ReportDetailAll, string filename = "ComplianceList")
        {
            var weatherForecast = new WeatherForecastXLS();
            var XLSStream = weatherForecast.ExportExcelAMLTestList(ReportDetailAll, "ComplianceList");

            await js.InvokeVoidAsync("BlazorDownloadFile", filename, XLSStream);
        }
        public async Task DownloadSampleRateAsync(IJSRuntime js, List<AgentRateModel> ReportDetailAll, string filename = "DownLoadSampleRate")
        {
            var weatherForecast = new WeatherForecastXLS();
            var XLSStream = weatherForecast.ExportExcelSampleRate(ReportDetailAll, "DownLoadSampleRate");

            await js.InvokeVoidAsync("BlazorDownloadFile", filename, XLSStream);
        }
        public async Task DownloadSampleRateOnlineAsync(IJSRuntime js, List<AgentRateModel> ReportDetailAll, string filename = "DownLoadSampleRateOnline")
        {
            var weatherForecast = new WeatherForecastXLS();
            var XLSStream = weatherForecast.ExportExcelSampleRateOnline(ReportDetailAll, "DownLoadSampleRateOnline");

            await js.InvokeVoidAsync("BlazorDownloadFile", filename, XLSStream);
        }
        public async Task DownloadSOFAsync(IJSRuntime js, List<AggregationModel> AggregationModels, string filename = "DownLoadASOF")
        {
            var weatherForecast = new WeatherForecastXLS();
            var XLSStream = weatherForecast.ExportSOF(AggregationModels, "DownLoadSOF");

            await js.InvokeVoidAsync("BlazorDownloadFile", filename, XLSStream);
        }
        public async Task DownloadAggregationAsync(IJSRuntime js, List<AggregationModel> AggregationModels, string filename = "DownLoadAggregation")
        {
            var weatherForecast = new WeatherForecastXLS();
            var XLSStream = weatherForecast.ExportAggregation(AggregationModels, "DownLoadAggregation");

            await js.InvokeVoidAsync("BlazorDownloadFile", filename, XLSStream);
        }
        public async Task DownloadAggregationOnlineAsync(IJSRuntime js, List<AggregationModel> AggregationModels, string filename = "DownLoadAggregationOnline")
        {
            var weatherForecast = new WeatherForecastXLS();
            var XLSStream = weatherForecast.ExportAggregationOnline(AggregationModels, "DownLoadAggregationOnline");

            await js.InvokeVoidAsync("BlazorDownloadFile", filename, XLSStream);
        }
        public async Task GenerateHistoryVoidRefundAsync(IJSRuntime js, List<ReportDetail> ReportDetailAll, string filename = "HistoryVoidRefund")
        {
            var weatherForecast = new WeatherForecastXLS();
            var XLSStream = weatherForecast.HistoryRefundVoidExcel(ReportDetailAll, "HistoryVoidRefund");

            await js.InvokeVoidAsync("BlazorDownloadFile", filename, XLSStream);
        }
        public async Task GenerateHistoryCancelAsync(IJSRuntime js, List<ReportDetail> ReportDetailAll, string filename = "HistoryCancel")
        {
            var weatherForecast = new WeatherForecastXLS();
            var XLSStream = weatherForecast.HistoryCancelExcel(ReportDetailAll, "HistoryCancel");

            await js.InvokeVoidAsync("BlazorDownloadFile", filename, XLSStream);
        }
        public async Task TemplateWeatherForecastAsync(IJSRuntime js, Stream streamTemplate, WeatherForecast[] data, string filename = "export")
        {
            var templateXLS = new UseTemplateXLS();
            var XLSStream = templateXLS.Edition(streamTemplate, data);

            await js.InvokeVoidAsync("BlazorDownloadFile", filename, XLSStream);
        }
        public async Task GenerateCompletedTransactionAsync(IJSRuntime js, List<ReportDetail> ReportDetailAll, string filename = "CompletedTransaction")
        {
            var weatherForecast = new WeatherForecastXLS();
            var XLSStream = weatherForecast.CompletedTransactionReportExcel(ReportDetailAll, "CompletedTransaction");

            await js.InvokeVoidAsync("BlazorDownloadFile", filename, XLSStream);
        }
        public async Task CommissionTransListsAsync(IJSRuntime js, List<ReportDetail> ReportDetailAll, string filename = "CommissionTransLists")
        {
            var weatherForecast = new WeatherForecastXLS();
            var XLSStream = weatherForecast.CommissionTransListsExcel(ReportDetailAll, "CommissionTransLists");
            await js.InvokeVoidAsync("BlazorDownloadFile", filename, XLSStream);
        }
        public async Task ApproveTransactionAsync(IJSRuntime js, List<ReportDetail> ReportDetailAll, string filename = "ApproveTransaction")
        {
            var weatherForecast = new WeatherForecastXLS();
            var XLSStream = weatherForecast.ApproveTransaction(ReportDetailAll, "ApproveTransaction");
            await js.InvokeVoidAsync("BlazorDownloadFile", filename, XLSStream);
        }
        public async Task ExportBillingReport(IJSRuntime js, List<ReportBillingSummary> reportSummarys, List<ReportDetail> reportDetails, List<ReportDetail> reportDetail1s, string filename = "ExportBillingReport")
        {
            var weatherForecast = new WeatherForecastXLS();
            var XLSStream = weatherForecast.ExportBillingReport(reportSummarys, reportDetails, reportDetail1s,"ExportBillingReport");
            await js.InvokeVoidAsync("BlazorDownloadFile", filename, XLSStream);
        }
        public async Task ExportViewBillingReport(IJSRuntime js, List<ReportBillingSummary> reportSummarys, List<ReportDetail> reportDetails, List<ReportDetail> reportDetail1s, string filename = "ExportBillingReport")
        {
            var weatherForecast = new WeatherForecastXLS();
            var XLSStream = weatherForecast.ExportViewBillingReport(reportSummarys, reportDetails, reportDetail1s, "ExportViewBillingReport");
            await js.InvokeVoidAsync("BlazorDownloadFile", filename, XLSStream);
        }
        public async Task ExportReviewAgentPayment(IJSRuntime js, List<AccountBalanceSummaryMocel> reportDetails, string filename = "ExportReviewAgentPayment")
        {
            var weatherForecast = new WeatherForecastXLS();
            var XLSStream = weatherForecast.ExportReviewAgentPayment(reportDetails, "ExportReviewAgentPayment");
            await js.InvokeVoidAsync("BlazorDownloadFile", filename, XLSStream);
        }
        public async Task ExportAccountBalanceSummary(IJSRuntime js, List<AccountBalanceSummaryMocel> reportDetails, string filename = "AccountBalanceSummary")
        {
            var weatherForecast = new WeatherForecastXLS();
            var XLSStream = weatherForecast.ExportAccountBalanceSummary(reportDetails, "AccountBalanceSummary");
            await js.InvokeVoidAsync("BlazorDownloadFile", filename, XLSStream);
        }
        public async Task ExportAgentAccountBalance(IJSRuntime js, List<AccountBalanceSummaryMocel> reportDetails, string filename = "AgentAccountBalance")
        {
            var weatherForecast = new WeatherForecastXLS();
            var XLSStream = weatherForecast.ExportAgentAccountBalance(reportDetails, "AgentAccountBalance");
            await js.InvokeVoidAsync("BlazorDownloadFile", filename, XLSStream);
        }
    }
}
