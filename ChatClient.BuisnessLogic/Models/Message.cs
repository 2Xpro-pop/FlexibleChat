using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatClient.BuisnessLogic.Models;
public class Message : Model
{
    public Guid UserId
    {
        get; set;
    }

    public Guid ChatId
    {
        get; set;
    }
}
