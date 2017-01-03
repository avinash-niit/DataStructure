using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListApp
{
    public class Project : IDisposable 
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public override string ToString()
        {
            return string.Format("Id: {0}\tName: {1}\n", Id, Name);
        }

        public override bool Equals(object obj)
        {
            Project temp = (Project)obj;
            return 
                Id==temp.Id && 
                Name.Equals(temp.Name,StringComparison.OrdinalIgnoreCase);
        }

        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                }

                disposedValue = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
        }
        #endregion
    }
}
