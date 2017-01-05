using System;

namespace LinkedListApp {
    public class Project : IComparable, IDisposable {
        public int Id { get; set; }

        public string Name { get; set; }

        #region System.Object Overrides

        public override string ToString() {
            return string.Format("Id: {0}\tName: {1}\n", Id, Name);
        }

        public override bool Equals(object obj) {
            bool flag = false;

            if (!ReferenceEquals(null, obj)) {
                if (!ReferenceEquals(this, obj)) {
                    Project temp = (Project)obj;
                    flag = temp.GetHashCode() == obj.GetHashCode();
                } else {
                    flag = true;
                }
            }
            return flag;
        }

        public override int GetHashCode() {
            unchecked {
                int hash = 17;
                hash = hash * 23 + Id.GetHashCode();
                hash = hash * 23 + Name.GetHashCode();
                return hash;
            }
        }

        #endregion

        #region IComparable
        public int CompareTo(object obj) {
            return Id.CompareTo((obj as Project).Id);
        }
        #endregion

        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing) {
            if (!disposedValue) {
                if (disposing) {
                }

                disposedValue = true;
            }
        }

        public void Dispose() {
            Dispose(true);
        }

        #endregion
    }
}
