using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 获取妹子的条件信息
 */
public class GirlGetConditionInfo : IMessageSerialize 
{
	//1:泡温泉次数 2:浦原商店购物次数 3:进阶次数 4:料理次数 5:连续登录天数 6:竞技场排名
	byte _type;	
	//对应type的值
	int _value;	
	
	/**
	 * 序列化
	 */
	public void Serialize(Stream stream)
	{
		//1:泡温泉次数 2:浦原商店购物次数 3:进阶次数 4:料理次数 5:连续登录天数 6:竞技场排名
		SerializeUtils.WriteByte(stream, _type);
		//对应type的值
		SerializeUtils.WriteInt(stream, _value);
	}
	
	/**
	 * 反序列化
	 */
	public void Deserialize(Stream stream)
	{
		//1:泡温泉次数 2:浦原商店购物次数 3:进阶次数 4:料理次数 5:连续登录天数 6:竞技场排名
		_type = SerializeUtils.ReadByte(stream);
		//对应type的值
		_value = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 1:泡温泉次数 2:浦原商店购物次数 3:进阶次数 4:料理次数 5:连续登录天数 6:竞技场排名
	 */
	public byte Type
	{
		set { _type = value; }
	    get { return _type; }
	}
	
	/**
	 * 对应type的值
	 */
	public int Value
	{
		set { _value = value; }
	    get { return _value; }
	}
	
}