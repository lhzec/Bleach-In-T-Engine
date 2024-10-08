using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 返回开启特训箱子结果 message
 */
public class ResOpenSpecialTrainingBoxMessage : Message 
{
	//特训的角色
	int _characterId;	
	//特训的buffId
	int _buffId;	
	//特训箱子信息
	BoxInfo _boxInfo;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//特训的角色
		SerializeUtils.WriteInt(stream, _characterId);
		//特训的buffId
		SerializeUtils.WriteInt(stream, _buffId);
		//特训箱子信息
		SerializeUtils.WriteBean(stream, _boxInfo);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//特训的角色
		_characterId = SerializeUtils.ReadInt(stream);
		//特训的buffId
		_buffId = SerializeUtils.ReadInt(stream);
		//特训箱子信息
		_boxInfo = SerializeUtils.ReadBean<BoxInfo>(stream);
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
	 * 特训的buffId
	 */
	public int BuffId
	{
		set { _buffId = value; }
	    get { return _buffId; }
	}
	
	/**
	 * 特训箱子信息
	 */
	public BoxInfo BoxInfo
	{
		set { _boxInfo = value; }
	    get { return _boxInfo; }
	}
	
	
	public override int GetId() 
	{
		return 310102;
	}
}