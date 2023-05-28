using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatClient.BuisnessLogic.Models;
public class User : Model
{
    public string Login
    {
        get; set;
    }

    public string Status
    {
        get; set;
    }
}
