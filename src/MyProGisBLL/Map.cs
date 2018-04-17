using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyGisBLL
{
    public class Map: IMap
    {
        private string _name = string.Empty;
        private List<ILayer> _layers = new List<ILayer>();
        Dictionary<Layer, ILayer> layerDict = new Dictionary<Layer, ILayer>();

        public int LayerCount;
        int IMap.LayerCount
        {
            get
            {
                return _layers.Count();
            }
        }

        ILayer IMap.GetLayer(string layerName)
        {
            return layerDict[layerName];
        }

        string IMap.Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        List<ILayer> IMap.Layers
        {
            get { return _layers; }
        }

        void IMap.AddLayer(ILayer layer)
        {
            _layers.Add(layer);

            //Array.Resize<ILayer>(ref _layers, _layers.Count + 1);
            //int newIndex = _layers.Length - 1;
            //_layers[newIndex] = (ILayer)layer;

        }

        void IMap.RemoveLayer(int index)
        {
            _layers.RemoveAt(index);

            //for (int i = 0; i < _layers.Length; i++)
            //{
              //  if (i < index)
                  //  _layers[i] = _layers[i];
                //if (i > index)
                    //_layers[i - 1] = _layers[i];
            //}
            //Array.Resize(ref _layers, _layers.Length - 1);
        }
    }
}
