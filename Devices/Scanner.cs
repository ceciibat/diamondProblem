namespace Fix.Devices
{
    internal class Scanner : Device, IScanner
    {
        public override void ProcessDoc(string document)             // isso vem da abstract class Device
        {
            Console.WriteLine("Scanner processing: " + document);
        }

        public string Scan()                                        // e isso vem do contrato da interface IScanner
        {
            return "Scanner scan result";
        }
    }
}
