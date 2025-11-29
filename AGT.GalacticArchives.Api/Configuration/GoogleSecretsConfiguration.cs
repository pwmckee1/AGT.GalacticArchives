using Google.Cloud.SecretManager.V1;

namespace AGT.GalacticArchives.Configuration;

public static class GoogleSecretsConfiguration
{
    public static string GetSecret(string projectId, string secretId)
    {
        var client = SecretManagerServiceClient.Create();

        var secretVersionName = new SecretVersionName(projectId, secretId, "1");

        var response = client.AccessSecretVersion(secretVersionName);

        return response.Payload.Data.ToStringUtf8();
    }
}