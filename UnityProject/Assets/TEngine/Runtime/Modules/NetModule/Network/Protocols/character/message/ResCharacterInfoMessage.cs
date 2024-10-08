using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 玩家的角色列表 message
 */
public class ResCharacterInfoMessage : Message 
{
	//角色消息
	List<CharacterInfos> _characterInfo = new List<CharacterInfos>();
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//角色消息
		SerializeUtils.WriteShort(stream, (short)_characterInfo.Count);

		foreach (var element in _characterInfo)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//角色消息
		int _characterInfo_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _characterInfo_length; ++i) 
		{
			_characterInfo.Add(SerializeUtils.ReadBean<CharacterInfos>(stream));
		}
	}
	
	/**
	 * get 角色消息
	 * @return 
	 */
	public List<CharacterInfos> GetCharacterInfo()
	{
		return _characterInfo;
	}
	
	/**
	 * set 角色消息
	 */
	public void SetCharacterInfo(List<CharacterInfos> characterInfo)
	{
		_characterInfo = characterInfo;
	}
	
	
	public override int GetId() 
	{
		return 200300;
	}
}