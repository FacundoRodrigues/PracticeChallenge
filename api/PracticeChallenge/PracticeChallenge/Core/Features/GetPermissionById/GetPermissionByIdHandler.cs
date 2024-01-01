using MediatR;
using PracticeChallenge.Core.Abstractions;
using PracticeChallenge.Core.Mapping;

namespace PracticeChallenge.Core.Features.GetPermissionById;

public class GetPermissionByIdHandler : IRequestHandler<GetPermissionByIdRequest, GetPermissionByIdResponse>
{
    private readonly IUnitOfWork _unitOfWork;

    public GetPermissionByIdHandler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<GetPermissionByIdResponse> Handle(GetPermissionByIdRequest request, CancellationToken cancellationToken)
    {
        var permission = await _unitOfWork.Permissions.GetPermissionByIdAsync(request.Id, cancellationToken);

        return new GetPermissionByIdResponse { Permission = permission.ToModel() };
    }
}