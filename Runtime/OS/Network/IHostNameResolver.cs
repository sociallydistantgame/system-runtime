#nullable enable
namespace OS.Network
{
	/// <summary>
	///		Interface for an object capable of performing hostname lookups.
	/// </summary>
	public interface IHostNameResolver
	{
		string? ReverseHostLookup(uint networkAddress);
		uint? HostLookup(string hostname);
	}
}