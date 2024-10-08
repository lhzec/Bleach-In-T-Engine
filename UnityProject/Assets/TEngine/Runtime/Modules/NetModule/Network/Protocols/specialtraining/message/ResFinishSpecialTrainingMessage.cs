using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 通知前端完成完成特训 message
 */
public class ResFinishSpecialTrainingMessage : Message 
{
	//特训的角色
	int _characterId;	
	//特训加强的buffId
	int _buffId;	
	//buff当前等级
	int _buffLevel;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//特训的角色
		SerializeUtils.WriteInt(stream, _characterId);
		//特训加强的buffId
		SerializeUtils.WriteInt(stream, _buffId);
		//buff当前等级
		SerializeUtils.WriteInt(stream, _buffLevel);
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
		//buff当前等级
		_buffLevel = SerializeUtils.ReadInt(stream);
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
	
	/**
	 * buff当前等级
	 */
	public int BuffLevel
	{
		set { _buffLevel = value; }
	    get { return _buffLevel; }
	}
	
	
	public override int GetId() 
	{
		return 310104;
	}
}