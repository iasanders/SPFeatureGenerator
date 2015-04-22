using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    public abstract class VirtualElement
    {
        protected VirtualFeature virtualFeature;
        private bool hasCustomFeature = false;

        public bool HasCustomFeature
        {
            get { return hasCustomFeature; }
            set { hasCustomFeature = value; }
        }

        public VirtualFeature VirtualFeature
        {
            get { return virtualFeature; }
            set 
            { 
                virtualFeature = value;
                hasCustomFeature = true;
            }
        }

        public abstract object GetKey();



        /// <summary>
        /// Not a property mapped to the xmlrepresentation!
        /// </summary>
        public Guid FeatureID
        {
            get 
            {
                if (hasCustomFeature)
                    return virtualFeature.Id;
                else
                    throw new ApplicationException("Feature has not been defined for this item");
            }

        }
    }
}
