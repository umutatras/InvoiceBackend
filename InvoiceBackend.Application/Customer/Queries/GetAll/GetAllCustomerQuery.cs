using InvoiceBackend.Application.Models.General;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceBackend.Application.Customer.Queries.GetAll;

public sealed class GetAllCustomerQuery : IRequest<ResponseDto<List<GetAllCustomerResponse>>>
{

}