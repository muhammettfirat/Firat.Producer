using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace Firat.Producer
{
    public interface IAddQueueAppService
    {
        Task Queue();
    }
}
