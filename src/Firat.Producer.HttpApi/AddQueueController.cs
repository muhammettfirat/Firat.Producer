using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Volo.Abp;

namespace Firat.Producer
{
    [Area(ProducerRemoteServiceConsts.ModuleName)]
    [RemoteService(Name = ProducerRemoteServiceConsts.RemoteServiceName)]
    [Route("api/Producer/addqueue")]
    public class AddQueueController:ProducerController,IAddQueueAppService
    {
        private readonly IAddQueueAppService _addQueueAppService;

        public AddQueueController(IAddQueueAppService addQueueAppService)
        {
          _addQueueAppService= addQueueAppService;
        }
        [HttpGet]
        public async Task Queue()
        {
          await _addQueueAppService.Queue();
        }
    }
}
