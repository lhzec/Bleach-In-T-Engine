using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 角色进阶请求 message
 */
public class ReqCharacterStageUpMessage : Message 
{
	//角色id
	int _charId;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//角色id
		SerializeUtils.WriteInt(stream, _charId);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//角色id
		_charId = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 角色id
	 */
	public int CharId
	{
		set { _charId = value; }
	    get { return _charId; }
	}
	
	
	public override int GetId() 
	{
		return 200102;
	}
}