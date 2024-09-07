using NeAvito.Application.AppServices.Ad.Repository;
using NeAvito.Contracts.Ad;

namespace NeAvito.Application.AppServices.Ad.Services
{
    /// <inheritdoc/>
    public class AdService : IAdService
    {
        private readonly IAdRepository _adRepository;

        public AdService(IAdRepository adRepository)
        {
            _adRepository = adRepository;
        }

        public Task<AdDto> AddAsync(AdCreateDto adCreateDto, Guid userId, CancellationToken cancellationToken)
        {
            var Id = Guid.NewGuid();
            var adDto = new AdDto()
            {
                Id = Id,
                Title = adCreateDto.Title,
                Description = adCreateDto.Description,
                Address = adCreateDto.Address,
                Price = adCreateDto.Price,
                CategoryId = adCreateDto.CategoryId,
                IsActive = true,
                AuthorId = userId,
                Created = DateTime.UtcNow,
                Updated = DateTime.UtcNow,
            };
            return _adRepository.AddAsync(adDto, cancellationToken);
        }

        public Task<bool> DeleteAsync(Guid id, CancellationToken cancellationToken)
        {
            return _adRepository.DeleteAsync(id, cancellationToken);
        }

        public Task<IEnumerable<AdDto>> GetAllAsync(CancellationToken cancellationToken)
        {
            return _adRepository.GetAllAsync(cancellationToken);
        }

        public Task<AdDto> GetAsync(Guid id, CancellationToken cancellationToken)
        {
            return GetAsync(id, cancellationToken);
        }

        public Task<AdDto> UpdateAsync(Guid id, AdUpdateDto adUpdateDto, CancellationToken cancellationToken)
        {
            return UpdateAsync(id, adUpdateDto, cancellationToken);
        }
    }
}
