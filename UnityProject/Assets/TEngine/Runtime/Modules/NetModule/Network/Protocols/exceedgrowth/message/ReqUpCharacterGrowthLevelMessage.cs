using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 前端请求提升角色成长率等级 message
 */
public class ReqUpCharacterGrowthLevelMessage : Message 
{
	//角色编号
	int _characterId;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//角色编号
		SerializeUtils.WriteInt(stream, _characterId);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//角色编号
		_characterId = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 角色编号
	 */
	public int CharacterId
	{
		set { _characterId = value; }
	    get { return _characterId; }
	}
	
	
	public override int GetId() 
	{
		return 222201;
	}
}