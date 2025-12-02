using Models.Entities;
using Repository.AluguelRepository;


namespace Service.AluguelService
{
    public class AluguelService
    {
        private readonly AluguelRepository _repository;

        #region Constructor
        public AluguelService(AluguelRepository repository)
        {
            _repository = repository;
        }

        public async Task<Aluguel> GetById(int id) 
        {
            return await _repository.GetByIdAsync(id);
        }
        public async Task<Aluguel> Add(Aluguel aluguel)
        {
            return await _repository.AddAsync(aluguel);
        }
        public async Task<Aluguel> Post(int id, Aluguel aluguel) 
        {
            return await _repository.PostAsync(id, aluguel);
        }
        public async Task<Aluguel> Delete(int id) 
        {
            return await _repository.DeleteAsync(id);
        }
        #endregion
    }
}
