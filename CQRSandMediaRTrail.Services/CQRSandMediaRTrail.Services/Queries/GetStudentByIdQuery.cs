using CQRSandMediaRTrail.Services.Models;
using MediatR;

namespace CQRSandMediaRTrail.Services.Queries
{
    public class GetStudentByIdQuery : IRequest<StudentDetails>
    {
        public int Id { get; set; }
    }
}
