using CQRSandMediaRTrail.Services.Commands;
using CQRSandMediaRTrail.Services.Models;
using CQRSandMediaRTrail.Services.Repositories;
using MediatR;

namespace CQRSandMediaRTrail.Services.Handlers
{
    public class CreateStudentHandler : IRequestHandler<CreateStudentCommand, StudentDetails>
    {
        private readonly IStudentRepository _studentRepository;

        public CreateStudentHandler(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }
        public async Task<StudentDetails> Handle(CreateStudentCommand command, CancellationToken cancellationToken)
        {
            var studentDetails = new StudentDetails()
            {
                StudentName = command.StudentName,
                StudentEmail = command.StudentEmail,
                StudentAddress = command.StudentAddress,
                StudentAge = command.StudentAge
            };

            return await _studentRepository.AddStudentAsync(studentDetails);
        }
    }
}
