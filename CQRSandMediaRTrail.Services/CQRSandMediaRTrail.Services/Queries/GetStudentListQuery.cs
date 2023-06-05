using CQRSandMediaRTrail.Services.Models;
using MediatR;

namespace CQRSandMediaRTrail.Services.Queries
{
    public class GetStudentListQuery : IRequest<List<StudentDetails>>
    {
    }
}
