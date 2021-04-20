using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Shop.Domain.Commands.Requests;
using Shop.Domain.Commands.Response;

namespace Shop.Domain.Commands.Handlers
{
    public class CreateCustomerHandler:IRequestHandler<CreateCustomerRequest,CreateCustomerResponse>
    {
     
       public Task<CreateCustomerResponse> Handle(CreateCustomerRequest request, CancellationToken cancellationToken)
        {
             //verificacoes
           //valida os dados
           //Insere os dados 
           //Envia o e-mail de boas vindas
             var result = new CreateCustomerResponse
            { 
                  Id = Guid.NewGuid(),
                  Name = "Leonardo Marques",
                  Email = "leo_marquesilva@hotmail.com",
                  Date = DateTime.Now
           };
        
            return Task.FromResult(result);
        }
    }
}