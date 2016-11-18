using ClassLibrary1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface IRepositoryMouse
    {
       IEnumerable<MouseEntity> GetMouse();

        MouseEntity GetMouseByID(int mouseId);
        void InsertMouse(MouseEntity mouse);
        void DeleteMouse(int mouseId);
        void UpdateMouse(MouseEntity mouse);
        void Save();
    }
}
