using ClassLibrary1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repozitory.Repositories
{
    public interface IRepositoryKeyboardEntity
    {
        IEnumerable<KeyboardEntity> KeyboardEntities { get; set; }

    }
}
