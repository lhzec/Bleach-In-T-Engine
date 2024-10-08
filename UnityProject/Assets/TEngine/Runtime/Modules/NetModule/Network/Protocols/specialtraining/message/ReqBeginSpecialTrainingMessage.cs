using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 前端请求开始特训 message
 */
public class ReqBeginSpecialTrainingMessage : Message 
{
	//特训的角色
	int _characterId;	
	//特训加强的buffId
	int _buffId;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//特训的角色
		SerializeUtils.WriteInt(stream, _characterId);
		//特训加强的buffId
		SerializeUtils.WriteInt(stream, _buffId);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//特训的角色
		_characterId = SerializeUtils.ReadInt(stream);
		//特训加强的buffId
		_buffId = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 特训的角色
	 */
	public int CharacterId
	{
		set { _characterId = value; }
	    get { return _characterId; }
	}
	
	/**
	 * 特训加强的buffId
	 */
	public int BuffId
	{
		set { _buffId = value; }
	    get { return _buffId; }
	}
	
	
	public override int GetId() 
	{
		return 310201;
	}
}