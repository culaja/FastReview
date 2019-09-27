using System;
using System.Linq;
using LibGit2Sharp;

namespace LibGit2SharpAdapter
{
    public class Adapter
    {
        public void Method()
        {
            var repository = new Repository(@"D:\github\EventStorePlayground\");

            var logEntries = repository.Commits.ToList();

            var c1 = logEntries.FirstOrDefault(le => le.Id.Sha == "29213ce9f926ee2449444a1b3e46ff6e33bf6f98");
            var c2 = logEntries.FirstOrDefault(le => le.Id.Sha == "ed0150364e02cafa98663820ce5d09bc4ceda176");

            //repository.Diff.Compare()


        }
    }
}