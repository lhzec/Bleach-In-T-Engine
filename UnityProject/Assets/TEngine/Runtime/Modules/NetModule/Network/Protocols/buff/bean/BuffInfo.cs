using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * Buff信息
 */
public class BuffInfo : IMessageSerialize 
{
	//Buff Id
	int _id;	
	//Buff等级
	int _level;	
	//buff强化系数
	int _enhance;	
	//角色id，0：系统，其他>0：角色id
	int _characterId;	
	//Buff剩余时间（秒）
	int _timeLeft;	
	//Buff剩余次数
	int _countLeft;	
	
	/**
	 * 序列化
	 */
	public void Serialize(Stream stream)
	{
		//Buff Id
		SerializeUtils.WriteInt(stream, _id);
		//Buff等级
		SerializeUtils.WriteInt(stream, _level);
		//buff强化系数
		SerializeUtils.WriteInt(stream, _enhance);
		//角色id，0：系统，其他>0：角色id
		SerializeUtils.WriteInt(stream, _characterId);
		//Buff剩余时间（秒）
		SerializeUtils.WriteInt(stream, _timeLeft);
		//Buff剩余次数
		SerializeUtils.WriteInt(stream, _countLeft);
	}
	
	/**
	 * 反序列化
	 */
	public void Deserialize(Stream stream)
	{
		//Buff Id
		_id = SerializeUtils.ReadInt(stream);
		//Buff等级
		_level = SerializeUtils.ReadInt(stream);
		//buff强化系数
		_enhance = SerializeUtils.ReadInt(stream);
		//角色id，0：系统，其他>0：角色id
		_characterId = SerializeUtils.ReadInt(stream);
		//Buff剩余时间（秒）
		_timeLeft = SerializeUtils.ReadInt(stream);
		//Buff剩余次数
		_countLeft = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * Buff Id
	 */
	public int Id
	{
		set { _id = value; }
	    get { return _id; }
	}
	
	/**
	 * Buff等级
	 */
	public int Level
	{
		set { _level = value; }
	    get { return _level; }
	}
	
	/**
	 * buff强化系数
	 */
	public int Enhance
	{
		set { _enhance = value; }
	    get { return _enhance; }
	}
	
	/**
	 * 角色id，0：系统，其他>0：角色id
	 */
	public int CharacterId
	{
		set { _characterId = value; }
	    get { return _characterId; }
	}
	
	/**
	 * Buff剩余时间（秒）
	 */
	public int TimeLeft
	{
		set { _timeLeft = value; }
	    get { return _timeLeft; }
	}
	
	/**
	 * Buff剩余次数
	 */
	public int CountLeft
	{
		set { _countLeft = value; }
	    get { return _countLeft; }
	}
	
}