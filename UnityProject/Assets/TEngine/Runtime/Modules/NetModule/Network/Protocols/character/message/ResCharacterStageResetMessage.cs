using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 重置角色阶段 message
 */
public class ResCharacterStageResetMessage : Message 
{
	//0:成功，1：失败
	byte _result;	
	//角色id
	int _characterId;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//0:成功，1：失败
		SerializeUtils.WriteByte(stream, _result);
		//角色id
		SerializeUtils.WriteInt(stream, _characterId);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//0:成功，1：失败
		_result = SerializeUtils.ReadByte(stream);
		//角色id
		_characterId = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 0:成功，1：失败
	 */
	public byte Result
	{
		set { _result = value; }
	    get { return _result; }
	}
	
	/**
	 * 角色id
	 */
	public int CharacterId
	{
		set { _characterId = value; }
	    get { return _characterId; }
	}
	
	
	public override int GetId() 
	{
		return 200203;
	}
}