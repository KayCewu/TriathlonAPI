﻿using CodeCollabra.Application.Exceptions;
using CodeCollabra.Application.Repositories;
using MediatR;

namespace CodeCollabra.Application.Feautures.Users.Queries.GetUserProfileDetail
{
    public class GetUserProfileDetailsQueryHandler : IRequestHandler<GetUserProfileDetailsQuery, GetUserProfileDetailsDTO>
    {
        private readonly IPointsRepository _pointsRepository;
        private readonly IUserRepository _userRepository;
        private readonly IAchievementsRepository _achievementsRepository;

        public GetUserProfileDetailsQueryHandler(IPointsRepository pointsRepository, IUserRepository userRepository, IAchievementsRepository achievementsRepository)
        {
            _achievementsRepository = achievementsRepository;
            _pointsRepository = pointsRepository;
            _userRepository = userRepository;
        }

        public async Task<GetUserProfileDetailsDTO> Handle(GetUserProfileDetailsQuery request, CancellationToken cancellationToken)
        {
            try
            {
                var user = await _userRepository.GetByIdAsync(request.id);

                var achievements = await _achievementsRepository.GetAllAsync();
                achievements = achievements.Where(x => x.UserId == request.id).ToList();

                var points = await _pointsRepository.GetAllAsync();
                var userPoints = points.FirstOrDefault(x => x.UserId == request.id);

                return new GetUserProfileDetailsDTO
                {
                    Achievements = achievements,
                    PointValue = userPoints.PointValue,
                    UserEmail = user.Email,
                    Username = user.Username
                };
                
            }
            catch (Exception)
            {
                throw new NotFoundException(nameof(Users), request.id);
            }
        }
    }
}
