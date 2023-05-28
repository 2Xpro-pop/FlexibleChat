using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatServer.Dal;
public interface ICommit: IDisposable
{
    void Commit();
}
