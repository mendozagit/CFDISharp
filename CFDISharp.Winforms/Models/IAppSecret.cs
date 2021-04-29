namespace CFDISharp.Winforms.Models
{
	public interface IAppSecret
	{

		string AppSecretName { get; set; }
		string Host { get; set; }
		string DbName { get; set; }
		string InstanceName { get; set; }
		string Password { get; set; }
		string Port { get; set; }
		string User { get; set; }

		string StandardSecurityConnectionString();
	}
}