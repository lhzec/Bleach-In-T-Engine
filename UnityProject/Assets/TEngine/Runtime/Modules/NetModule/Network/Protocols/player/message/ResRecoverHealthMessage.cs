using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 玩家体力回复 message
 */
public class ResRecoverHealthMessage : Message 
{
	//当前体力
	int _health;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//当前体力
		SerializeUtils.WriteInt(stream, _health);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//当前体力
		_health = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 当前体力
	 */
	public int Health
	{
		set { _health = value; }
	    get { return _health; }
	}
	
	
	public override int GetId() 
	{
		return 105105;
	}
}