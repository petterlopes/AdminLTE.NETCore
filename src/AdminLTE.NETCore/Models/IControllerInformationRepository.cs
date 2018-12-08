using System.Collections.Generic;

namespace AdminLTE.NETCore.Models
{
    public interface IControllerInformationRepository
    {
        List<ControllerInfo> GetAll();
    }
}