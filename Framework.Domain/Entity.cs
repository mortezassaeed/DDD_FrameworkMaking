using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Domain;
public abstract class Entity<TKey> 
{
    public TKey Id { get; protected set; }    
}
public abstract class AggregateRoot<T> : Entity<T>
{

}


