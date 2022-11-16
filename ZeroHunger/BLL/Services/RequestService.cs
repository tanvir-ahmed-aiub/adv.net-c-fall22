using BLL.DTOs;
using DAL.EF;
using DAL.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class RequestService
    {
        public static void Create (CollectionRequest col) { 
            CollectionReq collectionReq = new CollectionReq();
            collectionReq.Description = col.Description;
            collectionReq.PrevTime = col.PrevTime;
            collectionReq.Status = "Open";
            //call to dal
            new CollectioReqRepo().Add(collectionReq);
        }
    }
}
