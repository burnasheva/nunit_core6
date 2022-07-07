for (($i = 0); $i -lt 40000; $i++)
{
 $m='UnitTest' + $i;
 (Get-Content .\PrimeService_IsPrimeCould.cs) -Replace 'PrimeService_IsPrimeCould', $m | Set-Content .\NUnitTest$i.cs
}
