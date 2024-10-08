using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 请求战斗 message
 */
public class ReqStartTopArenaBattleMessage : Message 
{
	//1：副队级，2：队长级，3：总队级
	int _type;	
	//出战的角色的id
	List<int> _characterIds = new List<int>();
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//1：副队级，2：队长级，3：总队级
		SerializeUtils.WriteInt(stream, _type);
		//出战的角色的id
		SerializeUtils.WriteShort(stream, (short)_characterIds.Count);

		foreach (var element in _characterIds)  
		{
			SerializeUtils.WriteInt(stream, element);
		}
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//1：副队级，2：队长级，3：总队级
		_type = SerializeUtils.ReadInt(stream);
		//出战的角色的id
		int _characterIds_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _characterIds_length; ++i) 
		{
			_characterIds.Add(SerializeUtils.ReadInt(stream));
		}
	}
	
	/**
	 * 1：副队级，2：队长级，3：总队级
	 */
	public int Type
	{
		set { _type = value; }
	    get { return _type; }
	}
	
	/**
	 * get 出战的角色的id
	 * @return 
	 */
	public List<int> GetCharacterIds()
	{
		return _characterIds;
	}
	
	/**
	 * set 出战的角色的id
	 */
	public void SetCharacterIds(List<int> characterIds)
	{
		_characterIds = characterIds;
	}
	
	
	public override int GetId() 
	{
		return 503202;
	}
}