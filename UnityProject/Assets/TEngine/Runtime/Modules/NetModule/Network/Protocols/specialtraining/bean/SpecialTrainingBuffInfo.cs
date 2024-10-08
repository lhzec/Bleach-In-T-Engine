using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 角色特训buff信息
 */
public class SpecialTrainingBuffInfo : IMessageSerialize 
{
	//特训buffId
	int _buffId;	
	//特训buff等级
	int _level;	
	
	/**
	 * 序列化
	 */
	public void Serialize(Stream stream)
	{
		//特训buffId
		SerializeUtils.WriteInt(stream, _buffId);
		//特训buff等级
		SerializeUtils.WriteInt(stream, _level);
	}
	
	/**
	 * 反序列化
	 */
	public void Deserialize(Stream stream)
	{
		//特训buffId
		_buffId = SerializeUtils.ReadInt(stream);
		//特训buff等级
		_level = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 特训buffId
	 */
	public int BuffId
	{
		set { _buffId = value; }
	    get { return _buffId; }
	}
	
	/**
	 * 特训buff等级
	 */
	public int Level
	{
		set { _level = value; }
	    get { return _level; }
	}
	
}