using System;
using System.Collections;

namespace Collections.CustomEnumerators
{
	public class OrganizationEnumarator : IEnumerator
	{
        private readonly Organization organization;

        private int currentIndex = -1;

        private Employee currentEmployee;

        public OrganizationEnumarator(Organization organization)
		{
            this.organization = organization;

            
        }

        public object Current => this.currentEmployee;

        public bool MoveNext()
        {
            if (++currentIndex >= organization.Count)
                return false;

            this.currentEmployee = organization[currentIndex];

            return true;
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }
    }
}

