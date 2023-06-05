using MediatR;

namespace CQRSandMediaRTrail.Services.Commands
{
    public class DeleteStudentCommand : IRequest<int>
    {
        public int Id { get; set; }
    }
}
