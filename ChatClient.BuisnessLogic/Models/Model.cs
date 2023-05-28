using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatClient.BuisnessLogic.Models;
public abstract class Model
{
    public Guid Id { get; set; }

    public override int GetHashCode() => Id.GetHashCode();
    public override bool Equals(object? obj)
    {
        if(obj is not Model model) 
        {
            return false;
        }

        if(GetType() != model.GetType())
        {
            return false;
        }

        return model.Id.Equals(Id);
    }
}
