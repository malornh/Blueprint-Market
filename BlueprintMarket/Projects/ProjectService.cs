using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlueprintMarket
{
    public class ProjectService
    {
        private readonly IProjectRepository _projectRepository;

        public ProjectService(IProjectRepository projectRepository)
        {
            _projectRepository = projectRepository;
        }

        public Task<List<Project>> GetProjectsAsync()
        {
            return _projectRepository.GetProjectsAsync();
        }

        public Task<Project> GetProjectByIdAsync(int id)
        {
            return _projectRepository.GetProjectByIdAsync(id);
        }

        public Task CreateProjectAsync(Project project)
        {
            return _projectRepository.CreateProjectAsync(project);
        }

        public Task UpdateProjectAsync(Project project)
        {
            return _projectRepository.UpdateProjectAsync(project);
        }

        public Task DeleteProjectAsync(int id)
        {
            return _projectRepository.DeleteProjectAsync(id);
        }
    }
}
