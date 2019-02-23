namespace DotNet.Testcontainers.Clients
{
  using DotNet.Testcontainers.Core.Builder;

  internal interface ITestcontainersClient
  {
    // Wrap image and container query into proper response classes.
    bool ExistImageById(string id);

    bool ExistImageByName(string name);

    bool ExistContainerById(string id);

    bool ExistContainerByName(string name);

    string FindImageNameById(string id);

    string FindImageNameByName(string name);

    string FindContainerNameById(string id);

    string FindContainerNameByName(string name);

    void Start(string id);

    void Stop(string id);

    void Remove(string id);

    string Run(DockerContainerConfig dockerContainerConfig, DockerHostConfig dockerHostConfig);
  }
}