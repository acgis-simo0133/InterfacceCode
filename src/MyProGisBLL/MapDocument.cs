using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyGisBLL
{
    public class MapDocument:IMapDocument, IMapManager
    {
        private IMap _focusMap = new Map();
        private List<IMap> _maps = new List<IMap>();
        Dictionary<Map, IMap> mapDict = new Dictionary<Map, IMap>();

        IMap IMapDocument.FocusMap
        {
            get { return _focusMap; }
        }

        List<IMap> IMapDocument.Maps
        {
            get {return _maps;}               
        }

        IMap IMapDocument.GetMap(string name)
        {
            try
            {
                return mapDict.[name];
            }
            catch (KeyNotFoundException e)
            {
                return null;
            }
        }

        void IMapManager.AddMap(IMap map)
        {
            _maps.Add(map);
            //Array.Resize(ref _maps, _maps.Length + 1);
            //int newIndex = _maps.Length - 1;
            //_maps[newIndex] = (IMap)map;  
        }

        void IMapManager.RemoveMap(int index)
        {
            _maps.RemoveAt(index);
            //for (int i = 0; i < _maps.Length; i++)
            //{
              //  if (i < index)
                //    _maps[i] = _maps[i];
                //if (i > index)
                  //  _maps[i - 1] = _maps[i];
            //}
            //Array.Resize(ref _maps, _maps.Length - 1);
        }

        void IMapManager.SetFocusMap(int index)
        {
            _focusMap = _maps[index];
        }
    }
}
