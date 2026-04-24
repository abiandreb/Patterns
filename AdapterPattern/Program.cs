using AdapterPattern.MediaPlayer;
using AdapterPattern.Payment;

Console.WriteLine("=== Adapter Pattern Demo ===\n");

// =============================================
// Use Case 1: Media Player Adapters
// =============================================
Console.WriteLine("1. Media Player — adapting incompatible audio libraries:\n");

var audioPlayer = new AudioPlayer();

audioPlayer.RegisterPlayer(new Mp3Player());
audioPlayer.RegisterPlayer(new VlcPlayerAdapter(new VlcPlayer()));
audioPlayer.RegisterPlayer(new FlacPlayerAdapter(new FlacDecoder()));

Console.WriteLine();
audioPlayer.Play("mp3", "song.mp3");
audioPlayer.Play("vlc", "movie_soundtrack.vlc");
audioPlayer.Play("flac", "lossless_album.flac");
audioPlayer.Play("wav", "recording.wav");

// =============================================
// Use Case 2: Payment Gateway Adapters
// =============================================
Console.WriteLine("\n=============================================");
Console.WriteLine("\n2. Payment Gateway — unified interface for different providers:\n");

IPaymentProcessor[] processors =
[
    new StripeAdapter(new StripeApi()),
    new PayPalAdapter(new PayPalSdk())
];

foreach (var processor in processors)
{
    Console.WriteLine($"  Processing payment via {processor.Name}:");
    var success = processor.ProcessPayment("merchant_42", 99.99m, "USD");
    Console.WriteLine($"  Result: {(success ? "Success" : "Failed")}\n");
}
