using System;
using System.Collections.Generic;
using SMS.BusinessLogicLayer.Interfaces;
using SMS.DataAccessLayer;
using SMS.DataAccessLayer.Implementation;
using SMS.DomainEntites.ViewModel;
using Dapper;

namespace SMS.BusinessLogicLayer.Implementations
{
    public class EncodingManager : IEncodingManager
    {
        private readonly DapperRepository _dapperRepository = null;

        public EncodingManager()
        {
            _dapperRepository = new DapperRepository();
        }


        //public object GetMvReportInfo()
        //{
        //    try
        //    { 
        //      using (MvReportModel mvReportModel = new MvReportModel())
        //        {
        //            var reader = _dapperRepository.Querymultiple(StoredProcedure.GetMvReportInfo, null);
        //            var pendigRequest = reader.Read(typeof(MvPendingRequestModel));
        //            var taggedRequest = reader.Read(typeof(MvTagReportModel));
        //            mvReportModel.MvPendingRequestModel = pendigRequest.Cast<MvPendingRequestModel>().ToList();
        //            mvReportModel.MvTagReportModel = taggedRequest.Cast<MvTagReportModel>().ToList().Where(r => r.RequestTag == "AGING").OrderBy(x => x.Id).ToList();
        //            mvReportModel.MvOverdueTagModel = taggedRequest.Cast<MvTagReportModel>().ToList().Where(e => e.RequestTag == "OVERDUE").OrderBy(x => x.Id).ToList();
        //            mvReportModel.MvNotMovingTagModel = taggedRequest.Cast<MvTagReportModel>().ToList().Where(x => x.RequestTag == "NOTMOVING").OrderBy(x => x.Id).ToList();
        //            return mvReportModel;
        //        }

        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception("Error in EncodingManager.cs in GetMvReportInfo() method. The Error is: " + ex.Message);
        //    }


        //}

        //public IEnumerable<object> GetTrasactionType()
        //{
        //    try
        //    {
        //        var reader = _dapperRepository.Querymultiple(StoredProcedure.TestGetTrasactionType, null);
        //        var certificateList = reader.Read(typeof(CertificateTypeModel));
        //        return certificateList;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception("Error in EncodingManager.cs in GetTrasactionType() method. The Error is: " + ex.Message);
        //    }

        //}

        //public object SearchMvRequestWithHistory(int requestId)
        //{
        //    try
        //    {
        //        using (MvRequestWithHistoryModel mvRequestHistory = new MvRequestWithHistoryModel())
        //        {
        //            var param = new DynamicParameters();
        //            param.Add("@pRequestId", requestId);
        //            var reader = _dapperRepository.Querymultiple(StoredProcedure.GetMvRequestWithHistoryById, param);
        //            var requestDetail = reader.Read(typeof(MvRequestModel));
        //            var requestHistory = reader.Read(typeof(DocumentAuditModel));
        //            mvRequestHistory.MvRequest = requestDetail.Cast<MvRequestModel>().ToList();
        //            mvRequestHistory.RequestHistory = requestHistory.Cast<DocumentAuditModel>();
        //            return mvRequestHistory;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception("Error in EncodingManager.cs in SearchMvRequestWithHistory() method. The Error is: " + ex.Message);
        //    }
        //}

        //public IEnumerable<RequestDetailViewModel> GetRequestSummaryByQueueNumber(int queueNumber)
        //{
        //    var param = new DynamicParameters();
        //    param.Add("@pQueueTicketNumber", queueNumber);
        //    var reader = _dapperRepository.Querymultiple(StoredProcedure.GetRequestSummaryByQueueNumber, param);

        //    List<RequestDetailViewModel> requestDetailViewModel = new List<RequestDetailViewModel>();

        //    var requestSummary = reader.Read(typeof(RequestSummaryModel));
        //    var requesterDetail = reader.Read(typeof(RequesterViewModel));

        //    foreach (var requester in requesterDetail.Cast<RequesterViewModel>())
        //    {
        //        var requestDetail = new RequestDetailViewModel();
        //        var request = new List<RequestSummaryModel>();

        //        var listOfRequest = requestSummary.Cast<RequestSummaryModel>().Where(x => x.RequesterId == requester.Id);
        //        foreach (var item in listOfRequest)
        //        {
        //            request.Add(item);
        //        }
        //        requestDetail.RequestSummary = request;
        //        requestDetail.RequesterViewModel = requester;
        //        requestDetailViewModel.Add(requestDetail);
        //    }
           
        //    return requestDetailViewModel.AsEnumerable();

          

            
        //}

        /// <summary>
        /// This method return the request types based on outlet code.
        /// </summary>
        /// <param name="outletCode"></param>
        /// <param name="requestTypeOnly"></param>
        /// <returns></returns>
        public IEnumerable<object> GetRequestType(string outletCode, bool requestTypeOnly = false)
        {
            var param = new DynamicParameters();
            param.Add("@OutletCode", outletCode);
            param.Add("@RequestTypeOnly", requestTypeOnly);
            try
            {
                using (var reader = _dapperRepository.Querymultiple(StoredProcedure.AdminUpRequestTypeRetrieve, param))
                {
                    var requestTypes = reader?.Read(typeof(CertificateTypeModel));
                    return requestTypes;
                }
            }
            catch (Exception exp)
            {
                throw;
            }
           
        }
    }
}
