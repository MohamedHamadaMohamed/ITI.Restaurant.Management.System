using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Applicaton.Layer.UseCases.Generics.Commands
{
    public class DeleteCommand<TEntity,TKey> : IRequest<bool>
    {
        public DeleteCommand(TKey id)
        {
            Id = id;
        }

        public TKey Id { get; set; }
        
    }
}
